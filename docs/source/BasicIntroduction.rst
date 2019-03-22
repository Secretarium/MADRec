Introduction
============

This page contains a lightly-worded and easily digestable overview of the MADRec project. For more thorough 
and indepth information, see the :doc:`technical introduction <TechnicalIntroduction>` or the various architecture papers.

Presentation of MADRec
~~~~~~~~~~~~~~~~~~~~~~
Massive Anonymous Data Reconciliation, or Madrec, is the newest initiative to bring data into line from Europe's and Switzerland's biggest banks ahead of MiFID II.
The cooperation on a joint initiative to improve the quality of counter-party reference data with industry counterparts. This data, when dealing about client details, is often 
hard to harvest, costly to verify, and can't be disclosed. Data quality benchmarks is the capacity of comparing confidential data with competitors, without disclosing data, in order to 
measure the percentage of participants in and out of consensus. The measurement provides a good indicator of the data quality and reduces the scope of data to verify.


MADRec on Secretarium:
~~~~~~~~~~~~~~~~~~~~~~

Recent developments in the field of trusted execution environments represent a unique opportunity to emulate homomorphic cryptography and secure multi-party 
computing with unparalleled performances. Secretarium intends to be a multi-purpose platform to facilitate the development of confidentiality-driven applications, and 
provide the infrastructure railways to efficiently interact with the internet and other systems. Secretarium is intended as a safe harbour for private data, allowing people 
and companies to control, share and realise the full potential of their data. 
Secretarium hosts distributed services such as applications shared between untrusting parties, and can also host privacy respecting services for analytics, machine learning.

The Secretarium platform is the fruit of a number of Blockchain and cryptography experiments. We leverage new secure multi-party computing techniques and trusted execution 
environments to achieve strong security and privacy guaranties when data is at rest, in transit and in use with multiple untrusted (potentially adversary) parties. 
Ideally, a system such as Secretarium's is intended to satisfy some important properties: 
- **Secure**. The platform and data must be secure against penetration attacks that aim at gaining unauthorised access to data. The Secretarium protocol guarantees that private and confidential data stay under the control of their originator at all times. We follow the principle of end-to-end encryption throughout the life cycle of the data, none of Secretarium engineers or other node runners get access to the data in clear-text.

- **Integrity-preserving**. The platform's results must be tamper-proof including from the party performing the analysis - and must provably yield results as specified.  This mechanism is similar to the tamper-proof integrity mechanisms available on a Blockchain.

- **Privacy-preserving**. Queries results should consist of aggregated data, or simple yes/no answers, and never disclose individuals or companies private information stored in the ledger. This guarantee should hold when analysts obtain and combine outputs for multiple queries.

- **Flexible and Scalable**. The platform must support any type of applications and serve a large array of purposes. Data coupled with each application must be segregated to maximise performance. The platform must be multi-layered, modular, and scalable. Each layer consists of loosely-coupled micro-services providing flexibility to the platform.   The modularity of the architecture and flexibility in the layers allows for horizontal scaling of each layer independently and enables decoupled upgrade, addition and removal of services with no downtime.

- **Simplicity**. Secretarium's protocol is designed to facilitate integration with existing systems, especially to allow recent commonly used internet browsers to serve natively as clients. On top of proposing modern C++ as a language to program applications, Secretarium's intention is also to allow programmers to code in simple and accessible languages such as Javascript.


Secretarium applications are hosted on an internet-like network, where applications can be public or privately owned. To facilitate the development of distributed applications, 
we have engineered a Byzantine Fault Tolerant version of the RAFT algorithm, which allows applications to run without a single point of failure. Secretarium has the capacity of 
pushing notifications and data to end-users, and is designed for speed with finality of execution achieved in a split second. Throughput reaches thousands of transactions per 
second (tps) on a single application, and - applications being independent - it is designed to support millions of tps overall. To connect to an application hosted on Secretarium, 
end-users must follow the Secretarium Connection Protocol (SCP), a variant of the Transport Layer Security (TLS) 1.2 protocol.
As TLS, SCP guarantees a secure channel in the sense of authentication, privacy and integrity/reliability, against an adversary with bounded compute capability, and, in addition, SCP provides two extremely significant guarantees:

MADRec in the press
~~~~~~~~~~~~~~~~~~~

Foundation of the MADRec consortium: https://www.ubs.com/global/en/about_ubs/about_us/news/news.html/en/2017/12/11/news-release-MiFID-II.html 