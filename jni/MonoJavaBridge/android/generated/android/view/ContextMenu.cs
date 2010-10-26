namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ContextMenu_))]
	public partial interface ContextMenu : Menu
	{
		global::android.view.ContextMenu setHeaderTitle(int arg0);
		global::android.view.ContextMenu setHeaderTitle(java.lang.CharSequence arg0);
		global::android.view.ContextMenu setHeaderIcon(int arg0);
		global::android.view.ContextMenu setHeaderIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.ContextMenu setHeaderView(android.view.View arg0);
		void clearHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ContextMenu))]
	internal sealed partial class ContextMenu_ : java.lang.Object, ContextMenu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContextMenu_()
		{
			InitJNI();
		}
		internal ContextMenu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle13977;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle13977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle13977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle13978;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderTitle13978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderTitle13978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon13979;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon13979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon13979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon13980;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderIcon13980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderIcon13980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderView13981;
		 global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._setHeaderView13981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setHeaderView13981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ContextMenu;
		}
		internal static global::MonoJavaBridge.MethodId _clearHeader13982;
		 void android.view.ContextMenu.clearHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clearHeader13982);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clearHeader13982);
		}
		internal static global::MonoJavaBridge.MethodId _add13983;
		 global::android.view.MenuItem android.view.Menu.add(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add13984;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add13985;
		 global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add13986;
		 global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._add13986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._add13986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear13987;
		 void android.view.Menu.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._clear13987);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._clear13987);
		}
		internal static global::MonoJavaBridge.MethodId _size13988;
		 int android.view.Menu.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._size13988);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._size13988);
		}
		internal static global::MonoJavaBridge.MethodId _close13989;
		 void android.view.Menu.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._close13989);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._close13989);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey13990;
		 bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._isShortcutKey13990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._isShortcutKey13990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13991;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13992;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13993;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu13994;
		 global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._addSubMenu13994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addSubMenu13994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions13995;
		 int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ContextMenu_._addIntentOptions13995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._addIntentOptions13995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem13996;
		 void android.view.Menu.removeItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeItem13996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeItem13996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup13997;
		 void android.view.Menu.removeGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._removeGroup13997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._removeGroup13997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable13998;
		 void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupCheckable13998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupCheckable13998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible13999;
		 void android.view.Menu.setGroupVisible(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupVisible13999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupVisible13999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled14000;
		 void android.view.Menu.setGroupEnabled(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setGroupEnabled14000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setGroupEnabled14000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems14001;
		 bool android.view.Menu.hasVisibleItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._hasVisibleItems14001);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._hasVisibleItems14001);
		}
		internal static global::MonoJavaBridge.MethodId _findItem14002;
		 global::android.view.MenuItem android.view.Menu.findItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._findItem14002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._findItem14002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem14003;
		 global::android.view.MenuItem android.view.Menu.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextMenu_._getItem14003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._getItem14003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut14004;
		 bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performShortcut14004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performShortcut14004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction14005;
		 bool android.view.Menu.performIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_._performIdentifierAction14005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._performIdentifierAction14005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode14006;
		 void android.view.Menu.setQwertyMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextMenu_._setQwertyMode14006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextMenu_.staticClass, global::android.view.ContextMenu_._setQwertyMode14006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextMenu"));
			global::android.view.ContextMenu_._setHeaderTitle13977 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderTitle13978 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon13979 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderIcon13980 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._setHeaderView13981 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;");
			global::android.view.ContextMenu_._clearHeader13982 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clearHeader", "()V");
			global::android.view.ContextMenu_._add13983 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add13984 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add13985 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._add13986 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._clear13987 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "clear", "()V");
			global::android.view.ContextMenu_._size13988 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "size", "()I");
			global::android.view.ContextMenu_._close13989 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "close", "()V");
			global::android.view.ContextMenu_._isShortcutKey13990 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.ContextMenu_._addSubMenu13991 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu13992 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu13993 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addSubMenu13994 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.ContextMenu_._addIntentOptions13995 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.ContextMenu_._removeItem13996 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeItem", "(I)V");
			global::android.view.ContextMenu_._removeGroup13997 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "removeGroup", "(I)V");
			global::android.view.ContextMenu_._setGroupCheckable13998 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.ContextMenu_._setGroupVisible13999 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.ContextMenu_._setGroupEnabled14000 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.ContextMenu_._hasVisibleItems14001 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.ContextMenu_._findItem14002 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._getItem14003 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.ContextMenu_._performShortcut14004 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.ContextMenu_._performIdentifierAction14005 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.ContextMenu_._setQwertyMode14006 = @__env.GetMethodIDNoThrow(global::android.view.ContextMenu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
