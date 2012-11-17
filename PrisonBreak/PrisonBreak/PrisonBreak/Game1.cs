using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;



namespace PrisonBreak
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont Text;
		OutputText Test;
      /*  OutputText Words;
        int timeCounter = 0;
        int subIndex = 0;
        string output;
        bool ToLong = false;
        int loopcounter = 10;
		*/
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
          Vector2 FontPos;
        float FontRotation;

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
           
            Text = Content.Load<SpriteFont>("SpriteFont");
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
            FontPos = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2);

            FontRotation = 0;

		 Test = new OutputText();
			
          /*  Words = new OutputText();
             output = Words.Stuff();
			*/
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>           

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
       protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
		//Test.Update(gameTime);
		Test.Update(gameTime);

            // TODO: Add your update logic here


           /* timeCounter += gameTime.ElapsedGameTime.Milliseconds;
            if (timeCounter >= 150 && subIndex < output.Length)
            {
                if (subIndex > loopcounter)
                {
                    ToLong = true;
                    loopcounter += 10;
                }

                if (ToLong == true)
                {
                    output += "\n";
                    //FontPos.Y += 20;
                    ToLong = false;
                }

                timeCounter = 0;
                subIndex++;

            }
                */
            
            base.Update(gameTime);
        }
        
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            

          


            // Find the center of the string
           // Vector2 FontOrigin = Text.MeasureString(output) / 2;
            Vector2 FontOrigin = new Vector2(5,5);
			// Draw the string
          // spriteBatch.DrawString(Text, output.Substring(0, subIndex), FontPos, Color.Black,



			spriteBatch.DrawString(Text, Test.CurrentText, FontPos, Color.Black, FontRotation, FontOrigin, 1.0f, SpriteEffects.None, 0.5f);

			//FontRotation, FontOrigin, 1.0f, SpriteEffects.None, 0.5f);
            spriteBatch.End();


           

            base.Draw(gameTime);
        }
    }
}
