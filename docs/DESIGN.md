# Project City — Design Doc

*Working title. Living document. Last updated 2026-11-22.*

## 1. Pitch

A Stardew-style life sim set in a futuristic, tightly controlled city, inspired by *1984* and *Brave New World*. You arrive with nothing and choose what matters to you: work, grow, build a property empire, make friends, fall in love. You also choose a side. You can climb the system legally, feed the black market, or do a bit of both. Play solo or in co-op with up to 4 players.

**Pillars**
1. **Your life, your priorities.** It's a small open world with no single required path.
2. **Two tracks, one city.** The legal track and the dark track run side by side, and the city reacts to which one you lean into.
3. **Risk you can read.** Illegal actions always show their risk before you commit. Higher risk means higher reward.
4. **Slow, steady, scalable.** Passive income grows as you invest in property and operations.

## 2. Look & Feel

- 2D top-down pixel art.
- Real weather (rain, heat, smog and so on) affects the mood and some activities.
- Tone: the player picks a side. The world can feel orderly and safe, or oppressive and rotten, depending on where you stand.

## 3. Setting

- A futuristic state that provides everything its citizens "need." Unapproved production of anything is a crime.
- Aerial surveillance (drones and aircraft) means nothing can be grown outdoors. Real growing happens indoors with hydroponics.
- **Districts** unlock over time (see section 8).
- **The Undercity:** the city is built on older cities, layered like a modern Rome. There are sewers, ruins, artifacts, old tech, underground trade routes and their own NPCs. Patrols rarely go below, and only into the sectors beneath sensitive government buildings.

## 3a. Story (in progress)

- **The Party** runs the city: faceless, ruling through bureaus. *Name TBD: must be satirical, a double-entendre.*
- **The face of the Party** is a "common man" figure who celebrates the ordinary citizen, not a strongman. *Name TBD.*
- **The records bureau** rewrites history. It should be a "Bureau of …" title. *Name TBD.*
- **The old city:** a former city, under a former government, that the Party eventually took over. The Undercity holds the history that escaped the bureau's redactions.
- **The player** is relocated by routine assignment: no special reason, just a number. A blank slate.
- **The revolution is circular.** The underground resistance is secretly run by the Party. The game only ever **hints** at this and never confirms it, so players argue about it.
  - **Why:** there will always be some resistance. By running it, the Party controls it, turning dissent into a pressure valve and a way to watch the people most likely to cause trouble.
- **The city is the Party's capital.** The whole game takes place here, with no other cities or maps.
- **The black market hides in plain sight because the Party allows it.** Through the resistance, the Party knows about most black-market trading and events. It misses small, individual dealings but has a good read on general trends. That's what drives Campaigns (7.6): the Party reacts to trends, not to every single sale.
- **Underground vendors and NPCs** are tied to the dark paths: fences, forgers, smugglers, old-tech dealers, Undercity traders. (Under the theme: any of them could be on the Party's payroll.)

## 3b. Government & Control (in progress)

**Structure:** the Party sits at the top, fronted by its common-man face. Below it are **five bureaus**, and each has an NPC "face" the player can befriend or cross. *All names are working labels; final "Bureau of …" names TBD.*

| Bureau (working label) | Controls | Player touchpoints |
|---|---|---|
| **Records** | History, news, what is "true" | Redactions, propaganda content, the official story the Undercity contradicts |
| **Provision** | Rations, goods, housing supply, licensed farms | Ration store, farm permits, property purchases |
| **Order** | Patrols, checkpoints, drones, cameras, curfew | Patrol stops, bribes, fines, criminal record |
| **Wellness** | The state drug, public mood, "malaise" | Drug allotment, wellness messaging, malaise reports |
| **Assignment** | Jobs, relocation, clearance levels | Your job, career changes, zone clearance (legal track) |

**How the Party watches**
- **Neighbors & informants:** anyone might report you. This feeds NPC suspicion and opinions (7.7).
- **Drones & cameras:** visible, and denser in some streets and zones than others. This feeds the risk scale (7.4).
- **Citizen Standing:** a visible compliance score. High standing opens permits and clearance (the legal track). Low standing means more stops and closer looks.
  - **Standing can be bought.** Bribe the right officials, or get it "fixed" through the resistance. So a dark-track player who makes a lot of money can still buy access and keep progressing the story. There are two paths to the same doors.

**How the Party keeps people content**
- **Rations & provision:** everything is provided, and gratitude is expected.
- **Broadcasts & propaganda:** screens, radio, posters, and the common-man face addressing the city every evening.
- **Approved leisure:** state games, rallies and festivals.
- **Assignment & purpose:** everyone has a place. Being "unassigned" is the real fear.
- **The state drug** *(name TBD)*: mostly story and dialogue. The player gets an allotment and *can* take it, but it has no gameplay effect. NPCs talk about it, depend on it, recommend it, or quietly skip it. **No daily chore.**
  - **Carrying it is expected.** If a patrol stops you and you have no allotment on you, you get a very small Citizen Standing ding. You never have to take it, only to have it. *(Tentative: this item might be cut, but it matters for the vibe.)*

**Naming rule: names mean the opposite.** Every bureau name says the opposite of what the bureau does, like the Ministry of Peace running a war. Our names must be original, not borrowed from *1984*.

| Bureau | Name | The irony |
|---|---|---|
| Records | **Bureau of Transparency** ✅ | Nothing hidden, except everything it redacts |
| Provision | **Bureau of Choice** ✅ | Everything is issued; you choose nothing |
| Order | **Bureau of Liberty** ✅ | The police |
| Wellness | *TBD* | It sedates everyone |
| Assignment | **Bureau of Opportunity** ✅ | It tells you who to be |

- State drug: **Wake** ✅ (a sedative called Wake).
- Face of the Party: **Your Neighbor** ✅ ("Your Neighbor is watching out for you").

## 4. The Day

- About **15 minutes of real time** per in-game day.
- **The limit is the clock plus curfew.** There's no energy bar. Being out after curfew isn't automatically illegal, but it's riskier: more patrols and closer looks.
- Real weather, plus a calendar of **state holidays/rallies** and **underground gatherings** (festival equivalents).
- *Open: day length tuning, what closes after curfew, whether sleeping late has a cost.*

## 5. Progression Tracks

You can mix the two, but each has its own progression.

| | Legal track | Dark track |
|---|---|---|
| Growing | Licensed hydroponic farm + permit upgrades | Hidden grow-rooms in owned property |
| Districts | Clearance levels / permits | Forged papers / smuggler routes |
| Patrols | Clean record, fewer stops | Bribes, cultivated officers, concealment |
| Income | Farm output, rentals, career pay | Contraband sales, smuggling runs |

The game is open-ended with no final ending. Each track has big milestones, and you can keep playing forever.

## 6. Money & Passive Income

- Buy land and property for slow, steady income that scales.
- A **licensed hydroponic farm** with permits is legal. Anything grown or made outside it is illegal.
- Property does double duty: legal rent or a business up front, and hidden grow-rooms or storage behind the walls.

## 7. Core Systems

### 7.1 Hydroponics ("farming")
- Indoor grow racks in the licensed farm (legal) or hidden rooms (illegal).
- Starting crops: approved produce (legal). **Real coffee** is the first illegal crop.

### 7.2 Jobs & Careers
- Take a job, play short **shift minigames**, and level up a **career skill path** with perks. You can switch jobs anytime.
- **First job: Courier.** Legally it builds routes, speed and reliability. It also makes a natural cover for smuggling.
- Later: ministry clerk, maintenance tech, patrol officer and more.

### 7.3 Contraband
- **Real coffee** (grown) and **banned books/media** (made) come first.
- Later: medicine/remedies, uncensored tech, undercity artifacts.

### 7.4 Risk & Patrols
- A visible **risk scale** on every illegal action. Penalties are mostly **fines and lost goods**, with harsher ones at the top of the scale.
- **Patrol stop options:** bribe or talk your way out.
- **Concealment:** items with secret compartments at different concealment levels.
- **Patrol ranks** (beat cop → sergeant → …) have rising chances to find hidden goods because they know what to look for.

### 7.5 Bribery
- **Quick bribes:** choose an amount and see the odds, based on the officer, your reputation and active campaigns.
- **Cultivated officers:** long-term relationships with specific officers who learn to look the other way.

### 7.6 Campaigns
- The government reacts to what players do. Lots of coffee being sold → a "Coffee Crackdown": more inspections, higher street prices.
- Being cooperative or informing → praise, cheaper permits.
- Campaigns are how the city reacts to you, separate from real weather.

### 7.7 Relationships
- Stardew-style friendships and romance.
- Trust builds over time. NPCs notice what you do and form **suspicions and opinions**. Some admire resistance, others would report you.

### 7.8 Other Activities
- Decorating and upgrading homes, including hidden grow-rooms behind walls.
- Cooking and crafting (raw goods → higher-value goods).
- Exploring and scavenging the city and the Undercity.
- City events and festivals (state and underground).

### 7.9 Conflict
- **No fighting or killing in the city.**
- **Undercity:** optional but valuable conflict with tiered creatures/mobs. You can skip it, but progress is hard without some of it.

## 8. Zones

- **5–7 zones total**, all interconnected like Stardew's map. One capital city, no separate maps.
- Zones unlock through **clearance** (legal) or **forged papers / smuggler routes** (dark).

**Draft zone list (to confirm):**

| # | Zone | What's there |
|---|---|---|
| 1 | **Arrivals Block** (starter) | Worker housing, courier depot, ration store, market street, patrol checkpoint |
| 2 | **Old Market** | Narrow streets, stalls, workshops; black market hiding in plain sight |
| 3 | **The Works** | Industrial zone, licensed hydroponic farms, warehouses, rail yard |
| 4 | **Ministry Quarter** | Bureaus, the Party's capitol buildings, heaviest patrols |
| 5 | **The Heights** | Elite residences, luxury shops, high-value buyers for contraband |
| 6 | **The Undercity** | Layered ruins of the old city under all the other zones; dark-path vendors, traders, mobs, unredacted history |

*Optional 7th: a transit hub / city wall gate (arrivals, deportations, smuggling in and out).*

## 9. Starting Situation

The player is a **new arrival relocated by the state**. They get a tiny flat and an assigned job (courier), which works as a natural tutorial.

## 10. Co-op

- Optional, **up to 4 players**. **Built into the backend from day one**; solo is just co-op with no guests.
- **One player hosts.** All players have full autonomy (you're playing with people you trust).
- **One shared wallet.** Fines come out of it.
- **Criminal record and other penalties are personal**: only the player who got caught carries them.
- **In-game chat** for coordinating.
- *Open: shared home vs. separate homes/rooms.*

## 11. Technical Direction

- Godot 4.7, C#.
- `scripts/Core`: all game rules, no Godot code. These rules don't care how many players there are.
- `scripts/Game`: rendering, input, audio, networking glue.
- Host-authoritative networking. Players send actions to the host, and the host applies them to the shared state.
- Game data (items, crops, prices, NPCs, dialogue) lives in `data/` as plain JSON/CSV.

## 12. Assets

- Start with **placeholders and free assets** (CC0 / free packs).
- Buy paid packs only after the game proves cohesive and fun.

## 13. First Playable (Milestone 1)

Goal: prove that **a courier shift + optional smuggling + a patrol stop** is fun.

- One block of the starter district: flat, courier depot, market street, checkpoint.
- Walk around, take a delivery, and optionally carry hidden coffee or books.
- A patrol stop with bribe / talk options, visible odds, and rank-based detection.
- Clock and curfew running.
- Co-op: 2+ players in the same block with chat.

## 14. Open Questions

- **Story:** premise, factions, the main characters, what each track's milestones are.
- Co-op homes: shared or separate.
- Clock/curfew details.
- Licensed farm upgrade path.
- Undercity layers: how many, what's in each.
- Name of the game and the city.
