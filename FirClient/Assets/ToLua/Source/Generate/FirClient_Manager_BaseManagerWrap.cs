﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_Manager_BaseManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FirClient.Manager.BaseManager), typeof(BaseBehaviour));
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isOnUpdate", get_isOnUpdate, set_isOnUpdate);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isOnUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.Manager.BaseManager obj = (FirClient.Manager.BaseManager)o;
			bool ret = obj.isOnUpdate;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isOnUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isOnUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.Manager.BaseManager obj = (FirClient.Manager.BaseManager)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isOnUpdate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isOnUpdate on a nil value");
		}
	}
}

