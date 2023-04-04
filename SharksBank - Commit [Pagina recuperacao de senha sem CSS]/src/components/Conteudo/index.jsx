import React from "react";

import styles from "./index.module.css";

export function Conteudo({ titulo, subTitulo, descricao, children }) {
  return (
    <div className={styles.conteudo}>
      <div className={styles.containerText}>
        <h2>{titulo}</h2>
        <span className={styles.subTitulo}>{subTitulo}</span>
        <p>{descricao}</p>
      </div>
      <div className={styles.containerConteudoExterno}>{children}</div>
    </div>
  );
}
