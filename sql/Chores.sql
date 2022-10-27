-- Active: 1666715478973@@SG-mirror-push-8951-6845-mysql-master.servers.mongodirector.com@3306@garbageCollector
CREATE TABLE
IF NOT EXISTS chores(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) NOT NULL,
  importance int NOT NULL CHECK(importance <= 5),
  completed bool NOT NULL DEFAULT 0,
  day VARCHAR(255) NOT NULL,
  creatorId VARCHAR(255) NOT NULL,
  FOREIGN KEY(creatorId) REFERENCES accounts(id) ON DELETE CASCADE
)default charset utf8 COMMENT '';
