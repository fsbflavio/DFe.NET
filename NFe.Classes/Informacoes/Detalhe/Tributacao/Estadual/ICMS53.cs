﻿/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMS53 : ICMSBasico
    {
        private decimal? _qBCMonoDif;
        private decimal? _adRemICMSDif;
        private decimal? _vICMSMonoDif;

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        [XmlElement(Order = 2)]
        public Csticms CST { get; set; }

        /// <summary>
        ///     N41a - Quantidade tributada diferida 
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal? qBCMonoDif
        {
            get { return _qBCMonoDif.Arredondar(4); }
            set { _qBCMonoDif = value.Arredondar(4); }
        }

        public bool ShouldSerializeqBCMonoDif()
        {
            return qBCMonoDif.HasValue;
        }

        /// <summary>
        ///     N42 - Alíquota ad rem do imposto diferido
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? adRemICMSDif
        {
            get { return _adRemICMSDif.Arredondar(4); }
            set { _adRemICMSDif = value.Arredondar(4); }
        }

        public bool ShouldSerializeadRemICMSDif()
        {
            return adRemICMSDif.HasValue;
        }

        /// <summary>
        ///     N43 - Valor do ICMS diferido
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? vICMSMonoDif
        {
            get { return _vICMSMonoDif.Arredondar(2); }
            set { _vICMSMonoDif = value.Arredondar(2); }
        }

        public bool ShouldSerializevICMSMonoDif()
        {
            return vICMSMonoDif.HasValue;
        }

    }
}