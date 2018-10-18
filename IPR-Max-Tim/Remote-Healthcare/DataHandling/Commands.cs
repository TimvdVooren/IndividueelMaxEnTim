using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Remote_Healthcare.DataHandling
{
    class Commands
    {
        public static string tunnelKey;

        /// <summary>
        /// Gets all current active sessions from the server.
        /// </summary>
        /// <returns>The serialised JSON as a string</returns>
        public static string GetSessions()
        {
            //return "{\"id\" : \"session/list\"}";
            return JsonConvert.SerializeObject(new
            {
                id = "session/list"
            });
        }

        /// <summary>
        /// Creates a network tunnel between the current application and a VR application.
        /// </summary>
        /// <param name="apiKey">The api key for the session</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string CreateTunnel(string apiKey)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/create",
                data = new {
                    session = apiKey
                }
            });
        }

        /// <summary>
        /// Creates a node on the scene
        /// </summary>
        /// <param name="name">The name given to the new Node</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string CreateNode(string name)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/add",
                        data = new
                        {
                            name = name,
                            components = new
                            {
                                transform = new
                                {
                                    position = new JArray { -100, 0, -100 },
                                    scale = 1,
                                    rotation = new JArray { 0, 0, 0 }

                                },
                                terrain = new
                                {
                                    smoothnormals = true
                                }
                            }
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Add a bicycle to the current scene.
        /// </summary>
        /// <param name="name">The name for the Bicyle Node</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string AddBicycle(string name)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/add",
                        data = new
                        {
                            name = "bike",
                            components = new
                            {
                                transform = new
                                {
                                    position = new[] { 0, 0.15, 0 },
                                    scale = 0.01
                                },
                                model = new
                                {
                                    file = "data/Networkengine/models/bike/bike_anim.fbx",
                                    animated = true,
                                    animation = "Armature|Fietsen"
                                }
                            }
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Delete a given node from the scene.
        /// </summary>
        /// <param name="guid">The UID of the node to be deleted</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string DeleteNode(string guid)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/delete",
                        data = new
                        {
                            id = guid
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Updates the node to given value.
        /// </summary>
        /// <param name="tunnelData">The data to send through the tunnel</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string UpdateNode(string tunnelData)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/update",
                        data = new
                        {
                            id = "guid",
                            transform = new
                            {
                                position = new[] { 0, 0, 0 },
                                scale = 1.0,
                                rotation = new[] { 0, 0, 0 }
                            },
                            animation = new
                            {
                                name = "walk",
                                speed = 0.5
                            }
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Change the position of a terrain node by a given offset
        /// </summary>
        /// <param name="tunnelKey">The tunnel key for the VR connection</param>
        /// <param name="guid">The Node ID for the terrain</param>
        /// <param name="offset">The offset to move the node with</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string MoveNode(string guid, int[] offset){
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/update",
                        data = new
                        {
                            id = guid,
                            transform = new
                            {
                                position = new[] { offset[0], offset[1], offset[2] },
                                scale = 1.0,
                                rotation = new[] { 0, 0, 0 }
                            }
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Creates a terrain for things to move on
        /// </summary>
        /// <param name="sizeX">The vertical size of the terrain</param>
        /// <param name="sizeY">The horizontal size of the terrain</param>
        /// <param name="TerrainHeights">The 2D array of the heights of each point in the map</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string CreateTerrain(int sizeX, int sizeY, float[,] TerrainHeights)
        {
            int index = 0;
            float[] fheights = new float[sizeX*sizeY];
            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    fheights[index] = TerrainHeights[x, y];
                    index++;
                }
            }

            string output = JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/terrain/add",
                        data = new
                        {
                            size = new JArray {sizeX,sizeY},
                            heights = fheights
                        }
                    }
                }
            });
            return output;
        }

        /// <summary>
        /// Deletes the terrain.
        /// </summary>
        /// <returns>The serialised JSON as a string</returns>
        public static string DeleteTerrain()
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/terrain/delete",
                        data = new {}
                    }
                }
            });
        }

        /// <summary>
        /// Sets a texture on a given node.
        /// (Overloaded with a string for a custom texture)
        /// </summary>
        /// <param name="uuid">The node ID to apply the texture to</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string AddTexture(string uuid)
        {
            string texture = "lava";
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/addlayer",
                        data = new
                        {
                            id = uuid,
                            normal = "data/NetworkEngine/textures/terrain/" + texture + "_n.jpg",
                            diffuse = "data/NetworkEngine/textures/terrain/" + texture + "_d.jpg",
                            minHeight = 0,
                            maxHeight = 100,
                            fadeDist = 0.5

                        }
                    }
                }
            });
        }
        public static string AddTexture(string uuid, string textureName)
        {
            string texture = textureName;
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/addlayer",
                        data = new
                        {
                            id = uuid,
                            normal = "data/NetworkEngine/textures/terrain/" + texture + "_n.jpg",
                            diffuse = "data/NetworkEngine/textures/terrain/" + texture + "_d.jpg",
                            minHeight = 0,
                            maxHeight = 100,
                            fadeDist = 0.5

                        }
                    }
                }
            });
        }

        /// <summary>
        /// Gets a JSON structure of the scene. The scene is a recursive structure of nodes with all their components
        /// </summary>
        /// <returns>The serialised JSON as a string</returns>
        public static string GetScene()
        {
            return JsonConvert.SerializeObject(new
            {
                id = "scene/get"
            });
        }

        /// <summary>
        /// Resets the scene to starting parameters
        /// </summary>
        /// <returns>The serialised JSON as a string</returns>
        public static string ResetScene()
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/reset",
                        data = new { }
                    }
                }
            });
        }

        /// <summary>
        /// Saves the scene to a file. If overwrite is not specified, or false, the fill will not be overwritten and an error will be returned.
        /// </summary>
        /// <param name="filename">The filename for the new file</param>
        /// <param name="overwrite">Indicates if the file should be overwritten</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string SaveScene(string filename, bool overwrite)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/save",
                        data = new
                        {
                            filename = filename,
                            overwrite = overwrite
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Loads a scene from a file
        /// </summary>
        /// <param name="filename">The file to retrieve the scene from</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string LoadScene(string filename)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/load",
                        data = new
                        {
                            filename = filename
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Adds a visual road on top of the terrain
        /// </summary>
        /// <param name="routeUID">The Node ID to be assigned to the Route</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string AddVisualRoad(string routeUID)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/road/add",
                        data = new
                        {
                            route = routeUID,
                            diffuse = "data/NetworkEngine/textures/tarmac_diffuse.png",
                            normal = "data/NetworkEngine/textures/tarmac_normal.png",
                            specular = "data/NetworkEngine/textures/tarmac_specular.png",
                            
                            heightoffset = 0.01

                        }
                    }
                }
            });
        }

        /// <summary>
        /// Adds a route on the map
        /// </summary>     
        /// <returns>The serialised JSON as a string</returns>
        public static string AddRouteNode()
        {
            int roundness = 50;
            int offsetX = 200;
            int offsetY = 200;
            Random rnd = new Random();
            string output = JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "route/add",
                        data = new
                        {
                            nodes = new[]
                            {
                                // Figure-8 (approx.) 

                                #region old_fig8
                                // Did not get direction vectors working, straight corners for now
                                /*new{ pos = new [] {  50 - offsetX, 0, 200 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] {  72 - offsetX, 0, 147 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 125 - offsetX, 0, 125 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 178 - offsetX, 0, 147 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 222 - offsetX, 0, 253 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 275 - offsetX, 0, 275 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 328 - offsetX, 0, 253 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 350 - offsetX, 0, 200 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 328 - offsetX, 0, 147 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 275 - offsetX, 0, 125 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 222 - offsetX, 0, 147 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 178 - offsetX, 0, 253 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] { 125 - offsetX, 0, 275 - offsetY }, dir = new[] {   0, 0,   0 }},
                                new{ pos = new [] {  72 - offsetX, 0, 253 - offsetY }, dir = new[] {   0, 0,   0 }}, */
                                #endregion

                                new
                                {
                                    pos = new [] {  50 - offsetX, 0, 200 - offsetY},
                                    dir = new [] { 0, 0, 500}
                                },
                                new
                                {
                                    pos = new[] { 350 - offsetX, 0, 200 - offsetY},
                                    dir = new[] { 0, 0, 500}
                                }
                            }
                        }
                    }
                }
            });
            return output;
        }

        /// <summary>
        /// Sets a node to follow a premade route
        /// </summary>   
        /// <param name="routeID">The Node ID for the route to be followed</param>
        /// <param name="bikeUID">The node ID for the bike that should follow the path</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string FollowRoute(string routeID, string bikeUID)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "route/follow",
                        data = new
                        {
                            route = routeID,
                            node = bikeUID,
                            speed = 10.0,
                            offset = 0.0,
                            rotate = "XZ",
                            smoothing = 1.0,
                            followHeight = true,
                            rotateOffset = new[] {0,0,0 },
                            positionOffset = new[] {0,0,0}
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Changes the speed at which the node follows the route
        /// </summary>
        /// <param name="velocity">Indicates how fast the node moves across the route</param>
        /// <param name="bikenode">Indicates which bike we are talking about</param>
        public static string ChangeRouteFollowSpeed(float velocity, string bikenode)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "route/follow/speed",
                        data = new
                        {
                            node = bikenode,
                            speed = velocity
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Asks the server to return a nodeID with a specific name
        /// </summary>
        /// <param name="name">Name of node to find</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string FindNode(string name)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/find",
                        data = new {
                            name = name
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Connects the VR Camera to a Node (usually the bicycle node)
        /// </summary>
        /// <param name="cameraNodeId">The Node ID of the camera</param>
        /// <param name="parentNodeId">The Node ID of the parent node to connect the camera to</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string ConnectCameraToNode(string cameraNodeId, string parentNodeId)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/update",
                        data = new
                        {
                            id = cameraNodeId,
                            parent = parentNodeId,
                            transform = new
                            {
                                scale = 100
                            }
                        }
                    }
                }
            });
        }

        public static string ClearPanel(string panelUID)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/panel/clear",
                        data = new
                        {
                            id = panelUID,
                        }
                    }
                }
            });
        }

        public static string CreatePanel()
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/add",
                        data = new
                        {
                            name = "Panel",
                            components = new
                            {
                                transform = new
                                {
                                    position = new[] { -34, 121, 1 },
                                    rotation = new[] { -90, 90, -40 },
                                    scale = 1
                                },
                                panel = new
                                {
                                    size = new[] { 0.48, 0.30 },
                                    resolution = new[] { 512, 512 }
                                }
                            }
                        }
                    }
                }
            });
        }
        public static string CreatePanel(float width, float height)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/add",
                        data = new
                        {
                            name = "Panel",
                            components = new
                            {
                                transform = new
                                {
                                    position = new[] { 0, 1, 0 },
                                    rotation = new[] { 0, 0, 0 },
                                    scale = 1
                                },
                                panel = new
                                {
                                    size = new[] { width, height },
                                    resolution = new[] { 512, 512 },

                                }
                            }
                        }
                    }
                }
            });
        }

        public static string SetPanelBuffer(string panelId, string newText)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/panel/drawtext",
                        data = new
                        {
                            id = panelId,
                            text = newText,
                            position = new[] { 100, 100 }
                        }
                    }
                }
            });
        }

        public static string FillBufferWithText(string panelID, string newText, int fontSize, double[] location, float[] rgba){
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/panel/drawtext",
                        data = new
                        {
                            id = panelID,
                            text = newText,
                            size = fontSize,
                            position = new[] {location[0], location[1]},
                            color = new[] {rgba[0], rgba[1], rgba[2], rgba[3]},
                            font = "segoeui"
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Draws a line on the backbuffer of the Panel
        /// </summary>
        /// <param name="panelID">The node ID of the panel</param>
        /// <param name="startPos">The starting position of the line as array { x, y }</param>
        /// <param name="endPos">The end position of the line as array { x, y }</param>
        /// <param name="rgba">The color of the line</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string DrawLineOnPanel(string panelID, int[] startPos, int[] endPos, float[] rgba)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/panel/drawlines",
                        data = new
                        {
                            id = panelID,
                            width = 2,
                            lines = new[]
                            {
                                new[] { startPos[0],startPos[1], endPos[0],endPos[1], 0,0,0,1f }, // x1,y1, x2,y2, r,g,b,a
                            }
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Swaps the font and back buffer of the panel
        /// </summary>
        /// <param name="panelId">The node ID of the panel</param>
        /// <returns>The serialised JSON as a string</returns>
        public static string SwapPanelBuffer(string panelId)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/panel/swap",
                        data = new
                        {
                            id = panelId
                        }
                    }
                }
            });
        }

        public static string AddTree(string parentNodeId, int[] position, int[] rotation, int scale)
        {
            return JsonConvert.SerializeObject(new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnelKey,
                    data = new
                    {
                        id = "scene/node/add",
                        data = new
                        {
                            name = "Tree",
                            parent = parentNodeId,
                            components = new
                            {
                                position = new[] { 0, 0, 0 },
                                rotation = new[] { 0, 0, 0 },
                                scale    = scale
                            },
                            model = new
                            {
                                file = "data/NetworkEngine/models/trees/fantasy/tree1.obj",
                                cullbackfaces = false
                            }
                        }
                    }
                }
            });
        }
    }
}
