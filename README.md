# LiveSplit component for [Streamer.Bot](https://streamer.bot/)
This component aims to bring the following functionality:
- Connect to your instance of Streamer.bot
- Add/Remove event triggers to happen on specific parts of your run through LiveSplit such as
  - Being on a specific split name (In progress)
  - Being ahead / behind (In progress)
  - Starting / Resetting a run (In progress)

## How to use
1. Import the DLL generated within your Livesplit/Components folder, you will also need the Newtonsoft.Json.dll in there as well.
2. Edit LiveSplit layout, you can find this component under the "Other" category.
3. Ensure you have Streamer.bot running with an available websocket server.
4. Input connection details and connect!
