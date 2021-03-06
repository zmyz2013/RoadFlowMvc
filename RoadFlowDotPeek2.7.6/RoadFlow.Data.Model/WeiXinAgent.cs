﻿// Decompiled with JetBrains decompiler
// Type: RoadFlow.Data.Model.WeiXinAgent
// Assembly: RoadFlow.Data.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B924143B-AEC1-4AFA-B627-1D84458A850C
// Assembly location: C:\inetpub\wwwroot\RoadFlowMvc\bin\RoadFlow.Data.Model.dll

using System;
using System.Collections.Generic;

namespace RoadFlow.Data.Model
{
  public class WeiXinAgent
  {
    public int agentid { get; set; }

    public int report_location_flag { get; set; }

    public string logo_mediaid { get; set; }

    public string name { get; set; }

    public string description { get; set; }

    public string redirect_domain { get; set; }

    public int isreportuser { get; set; }

    public int isreportenter { get; set; }

    public string home_url { get; set; }

    public string chat_extension_url { get; set; }

    public string square_logo_url { get; set; }

    public string round_logo_url { get; set; }

    public int type { get; set; }

    public int close { get; set; }

    public List<Tuple<string, int>> allow_userinfos { get; set; }

    public string allow_partys { get; set; }

    public string allow_tags { get; set; }
  }
}
