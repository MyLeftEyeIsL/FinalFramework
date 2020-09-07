﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_Component_CTimerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FirClient.Component.CTimer), typeof(BaseObject));
		L.RegFunction("Create", Create);
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("OnUpdate", OnUpdate);
		L.RegFunction("AddTimer", AddTimer);
		L.RegFunction("AddLuaTimer", AddLuaTimer);
		L.RegFunction("RemoveTimer", RemoveTimer);
		L.RegFunction("CreateTicker", CreateTicker);
		L.RegFunction("OnDispose", OnDispose);
		L.RegFunction("New", _CreateFirClient_Component_CTimer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFirClient_Component_CTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FirClient.Component.CTimer obj = new FirClient.Component.CTimer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FirClient.Component.CTimer.New");
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
			FirClient.Component.CTimer o = FirClient.Component.CTimer.Create();
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
			FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
			obj.Initialize();
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
			FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
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
	static int AddTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				System.Action<object> arg2 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 4);
				FirClient.Component.TimerInfo o = obj.AddTimer(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				System.Action<object> arg2 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				FirClient.Component.TimerInfo o = obj.AddTimer(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 6)
			{
				FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				System.Action<object> arg2 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 4);
				object arg3 = ToLua.ToVarObject(L, 5);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
				FirClient.Component.TimerInfo o = obj.AddTimer(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FirClient.Component.CTimer.AddTimer");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddLuaTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			LuaTable arg2 = ToLua.CheckLuaTable(L, 4);
			LuaFunction arg3 = ToLua.CheckLuaFunction(L, 5);
			object arg4 = ToLua.ToVarObject(L, 6);
			bool arg5 = LuaDLL.luaL_checkboolean(L, 7);
			FirClient.Component.TimerInfo o = obj.AddLuaTimer(arg0, arg1, arg2, arg3, arg4, arg5);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
			FirClient.Component.TimerInfo arg0 = (FirClient.Component.TimerInfo)ToLua.CheckObject<FirClient.Component.TimerInfo>(L, 2);
			obj.RemoveTimer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateTicker(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
			System.Collections.Generic.Dictionary<uint,uint> arg0 = (System.Collections.Generic.Dictionary<uint,uint>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<uint,uint>));
			object arg1 = ToLua.ToVarObject(L, 3);
			System.Action<uint,object> arg2 = (System.Action<uint,object>)ToLua.CheckDelegate<System.Action<uint,object>>(L, 4);
			obj.CreateTicker(arg0, arg1, arg2);
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
			FirClient.Component.CTimer obj = (FirClient.Component.CTimer)ToLua.CheckObject<FirClient.Component.CTimer>(L, 1);
			obj.OnDispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

