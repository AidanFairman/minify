CREATE DATABASE IF NOT EXISTS minify;
USE minify;
CREATE TABLE IF NOT EXISTS mapping (
    id BIGINT NOT NULL AUTO_INCREMENT,
    short VARCHAR(36) NOT NULL UNIQUE,
    full_url VARCHAR(1024) NOT NULL,
    PRIMARY KEY (id)
);
DELIMITER $$
DROP PROCEDURE IF EXISTS getMapping $$
DROP PROCEDURE IF EXISTS addMapping $$
CREATE PROCEDURE getMapping
(IN mini VARCHAR(36))
BEGIN
    SELECT full_url
    FROM mapping
    WHERE short = mini;
END $$

CREATE PROCEDURE addMapping
(IN mini VARCHAR(36),
IN full VARCHAR(1024))
BEGIN
    INSERT INTO mapping
    (short, full_url)
    VALUES
    (mini, full);
END $$
DELIMITER ;