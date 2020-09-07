﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TableManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TableManager), typeof(BaseObject));
		L.RegFunction("Create", Create);
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("LoadTables", LoadTables);
		L.RegFunction("OnUpdate", OnUpdate);
		L.RegFunction("OnDispose", OnDispose);
		L.RegFunction("New", _CreateTableManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("globalConfigTable", get_globalConfigTable, set_globalConfigTable);
		L.RegVar("itemTable", get_itemTable, set_itemTable);
		L.RegVar("npcTable", get_npcTable, set_npcTable);
		L.RegVar("qualityTable", get_qualityTable, set_qualityTable);
		L.RegVar("objectPoolTable", get_objectPoolTable, set_objectPoolTable);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTableManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TableManager obj = new TableManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TableManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			TableManager o = TableManager.Create();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TableManager obj = (TableManager)ToLua.CheckObject<TableManager>(L, 1);
			obj.Initialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadTables(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TableManager obj = (TableManager)ToLua.CheckObject<TableManager>(L, 1);
			obj.LoadTables();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TableManager obj = (TableManager)ToLua.CheckObject<TableManager>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.OnUpdate(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TableManager obj = (TableManager)ToLua.CheckObject<TableManager>(L, 1);
			obj.OnDispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_globalConfigTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			GlobalConfigTable ret = obj.globalConfigTable;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index globalConfigTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			ItemTable ret = obj.itemTable;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_npcTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			NpcTable ret = obj.npcTable;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index npcTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_qualityTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			QualityTable ret = obj.qualityTable;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index qualityTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_objectPoolTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			ObjectPoolTable ret = obj.objectPoolTable;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index objectPoolTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_globalConfigTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			GlobalConfigTable arg0 = (GlobalConfigTable)ToLua.CheckObject<GlobalConfigTable>(L, 2);
			obj.globalConfigTable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index globalConfigTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			ItemTable arg0 = (ItemTable)ToLua.CheckObject<ItemTable>(L, 2);
			obj.itemTable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_npcTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			NpcTable arg0 = (NpcTable)ToLua.CheckObject<NpcTable>(L, 2);
			obj.npcTable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index npcTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_qualityTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			QualityTable arg0 = (QualityTable)ToLua.CheckObject<QualityTable>(L, 2);
			obj.qualityTable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index qualityTable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_objectPoolTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TableManager obj = (TableManager)o;
			ObjectPoolTable arg0 = (ObjectPoolTable)ToLua.CheckObject<ObjectPoolTable>(L, 2);
			obj.objectPoolTable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index objectPoolTable on a nil value");
		}
	}
}

