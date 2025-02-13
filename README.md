# 🦊 RedFox.DocumentDb.EventSourcing

RedFox.DocumentDb.EventSourcing is a .NET library designed to bring event sourcing to Microsoft DocumentDB with PostgreSQL. It provides a scalable, high-performance solution for storing and replaying events in distributed applications, making event-driven architectures easier to implement.

## 👀 What’s in this repo?

This repository contains the `RedFox.DocumentDb.EventSourcing` library, providing a structured and efficient way to implement event sourcing on Microsoft DocumentDB.

Features:  
✅ Optimized for Event Sourcing – Append-only, immutable event storage  
✅ Seamless .NET Integration – Built for ASP.NET Core with Dependency Injection support  
✅ High Performance – Efficient event retrieval and replaying  
✅ Cloud & Kubernetes Ready – Designed for scalable and distributed architectures  
✅ PostgreSQL-backed Document Storage – Utilizing Microsoft’s latest DocumentDB technology

## 🛟 Support & Contributions

We offer support plans for enterprise users and encourage community contributions!

🔗 Check out RedFox support plans  
🤝 Sponsor the project on GitHub

## 💎 Our Commitment to Open Source & Enterprise Stability

At RedFox, we believe that event sourcing should always be open, transparent, and accessible. That’s why **RedFox.DocumentDb.EventSourcing** is and always will be 100% open-source under the permissive MIT license. Companies can confidently integrate our technology into their mission-critical applications, knowing that their data architecture will never be disrupted by restrictive licensing changes or vendor lock-in.

We are committed to long-term stability, security, and interoperability, ensuring that businesses can build event-driven solutions with confidence. While the core library remains open and free, our enterprise support plans provide expert assistance with troubleshooting, upgrades, performance optimizations, and architectural guidance, helping organizations maximize their investment in event sourcing with Microsoft DocumentDB.

## 📦 Getting Started

RedFox.DocumentDb.EventSourcing is available as a NuGet package:
🔗 NuGet Package

### Installation

#### Using .NET CLI

```powershell
dotnet add package RedFox.DocumentDb.EventSourcing
```

#### Using Package Manager

```powershell
NuGet\Install-Package RedFox.DocumentDb.EventSourcing
```

## 🛠️ How to Use

### 1️⃣ Configure Event Store

Register the event store in your ASP.NET Core service container:

```csharp
services.AddDocumentDbEventStore(options =>
{
    options.ConnectionString = "your-documentdb-connection";
    options.DatabaseName = "events";
});
```

### 2️⃣ Store Events

Save domain events to the event store:

```csharp
await eventStore.AppendAsync("stream-id", new UserCreatedEvent { UserId = 123 });
```

### 3️⃣ Retrieve and Replay Events

```csharp
var events = await eventStore.ReadStreamAsync("UserCreated");

foreach (var ev in events)
{
    Console.WriteLine(ev.Data);
}
```

## 📜 License

RedFox.DocumentDb.EventSourcing is licensed under the MIT License, allowing both private and commercial use.
Make sure to include a copy of the license in your project.

Join us in redefining event-driven architectures with Microsoft DocumentDB! 🚀
