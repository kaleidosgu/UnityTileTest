
// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class map
{

    private mapTileset tilesetField;

    private mapLayer layerField;

    private decimal versionField;

    private string tiledversionField;

    private string orientationField;

    private string renderorderField;

    private sbyte compressionlevelField;

    private byte widthField;

    private byte heightField;

    private byte tilewidthField;

    private byte tileheightField;

    private byte infiniteField;

    private byte nextlayeridField;

    private byte nextobjectidField;

    /// <remarks/>
    public mapTileset tileset
    {
        get
        {
            return this.tilesetField;
        }
        set
        {
            this.tilesetField = value;
        }
    }

    /// <remarks/>
    public mapLayer layer
    {
        get
        {
            return this.layerField;
        }
        set
        {
            this.layerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tiledversion
    {
        get
        {
            return this.tiledversionField;
        }
        set
        {
            this.tiledversionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string orientation
    {
        get
        {
            return this.orientationField;
        }
        set
        {
            this.orientationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string renderorder
    {
        get
        {
            return this.renderorderField;
        }
        set
        {
            this.renderorderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public sbyte compressionlevel
    {
        get
        {
            return this.compressionlevelField;
        }
        set
        {
            this.compressionlevelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte tilewidth
    {
        get
        {
            return this.tilewidthField;
        }
        set
        {
            this.tilewidthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte tileheight
    {
        get
        {
            return this.tileheightField;
        }
        set
        {
            this.tileheightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte infinite
    {
        get
        {
            return this.infiniteField;
        }
        set
        {
            this.infiniteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte nextlayerid
    {
        get
        {
            return this.nextlayeridField;
        }
        set
        {
            this.nextlayeridField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte nextobjectid
    {
        get
        {
            return this.nextobjectidField;
        }
        set
        {
            this.nextobjectidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mapTileset
{

    private byte firstgidField;

    private string sourceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte firstgid
    {
        get
        {
            return this.firstgidField;
        }
        set
        {
            this.firstgidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mapLayer
{

    private mapLayerData dataField;

    private byte idField;

    private string nameField;

    private byte widthField;

    private byte heightField;

    /// <remarks/>
    public mapLayerData data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class mapLayerData
{

    private string encodingField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string encoding
    {
        get
        {
            return this.encodingField;
        }
        set
        {
            this.encodingField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

