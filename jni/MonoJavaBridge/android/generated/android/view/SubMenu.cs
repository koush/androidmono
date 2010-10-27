namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.SubMenu_))]
	public partial interface SubMenu : Menu
	{
		global::android.view.MenuItem getItem();
		global::android.view.SubMenu setIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.SubMenu setIcon(int arg0);
		global::android.view.SubMenu setHeaderTitle(int arg0);
		global::android.view.SubMenu setHeaderTitle(java.lang.CharSequence arg0);
		global::android.view.SubMenu setHeaderIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.SubMenu setHeaderIcon(int arg0);
		global::android.view.SubMenu setHeaderView(android.view.View arg0);
		void clearHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.SubMenu))]
	internal sealed partial class SubMenu_ : java.lang.Object, SubMenu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SubMenu_()
		{
			InitJNI();
		}
		internal SubMenu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getItem14488;
		global::android.view.MenuItem android.view.SubMenu.getItem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._getItem14488)) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._getItem14488)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon14489;
		global::android.view.SubMenu android.view.SubMenu.setIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setIcon14489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setIcon14489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon14490;
		global::android.view.SubMenu android.view.SubMenu.setIcon(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setIcon14490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setIcon14490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle14491;
		global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderTitle14491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderTitle14491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderTitle14492;
		global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderTitle14492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderTitle14492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon14493;
		global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderIcon14493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderIcon14493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderIcon14494;
		global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderIcon14494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderIcon14494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setHeaderView14495;
		global::android.view.SubMenu android.view.SubMenu.setHeaderView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._setHeaderView14495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setHeaderView14495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _clearHeader14496;
		void android.view.SubMenu.clearHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._clearHeader14496);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._clearHeader14496);
		}
		internal static global::MonoJavaBridge.MethodId _add14497;
		global::android.view.MenuItem android.view.Menu.add(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add14497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add14497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add14498;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add14498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add14498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add14499;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add14499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add14499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add14500;
		global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._add14500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._add14500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear14501;
		void android.view.Menu.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._clear14501);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._clear14501);
		}
		internal static global::MonoJavaBridge.MethodId _size14502;
		int android.view.Menu.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.SubMenu_._size14502);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._size14502);
		}
		internal static global::MonoJavaBridge.MethodId _close14503;
		void android.view.Menu.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._close14503);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._close14503);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey14504;
		bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._isShortcutKey14504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._isShortcutKey14504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14505;
		global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu14505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu14505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14506;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu14506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu14506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14507;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu14507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu14507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14508;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._addSubMenu14508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addSubMenu14508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions14509;
		int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.SubMenu_._addIntentOptions14509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._addIntentOptions14509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem14510;
		void android.view.Menu.removeItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._removeItem14510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._removeItem14510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup14511;
		void android.view.Menu.removeGroup(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._removeGroup14511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._removeGroup14511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable14512;
		void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setGroupCheckable14512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setGroupCheckable14512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible14513;
		void android.view.Menu.setGroupVisible(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setGroupVisible14513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setGroupVisible14513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled14514;
		void android.view.Menu.setGroupEnabled(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setGroupEnabled14514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setGroupEnabled14514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems14515;
		bool android.view.Menu.hasVisibleItems()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._hasVisibleItems14515);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._hasVisibleItems14515);
		}
		internal static global::MonoJavaBridge.MethodId _findItem14516;
		global::android.view.MenuItem android.view.Menu.findItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._findItem14516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._findItem14516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem14517;
		global::android.view.MenuItem android.view.Menu.getItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.SubMenu_._getItem14517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._getItem14517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut14518;
		bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._performShortcut14518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._performShortcut14518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction14519;
		bool android.view.Menu.performIdentifierAction(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.SubMenu_._performIdentifierAction14519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._performIdentifierAction14519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode14520;
		void android.view.Menu.setQwertyMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.SubMenu_._setQwertyMode14520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.SubMenu_.staticClass, global::android.view.SubMenu_._setQwertyMode14520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SubMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SubMenu"));
			global::android.view.SubMenu_._getItem14488 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "getItem", "()Landroid/view/MenuItem;");
			global::android.view.SubMenu_._setIcon14489 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setIcon14490 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderTitle14491 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderTitle14492 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderIcon14493 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderIcon14494 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._setHeaderView14495 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._clearHeader14496 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "clearHeader", "()V");
			global::android.view.SubMenu_._add14497 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._add14498 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._add14499 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._add14500 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._clear14501 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "clear", "()V");
			global::android.view.SubMenu_._size14502 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "size", "()I");
			global::android.view.SubMenu_._close14503 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "close", "()V");
			global::android.view.SubMenu_._isShortcutKey14504 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.SubMenu_._addSubMenu14505 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addSubMenu14506 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addSubMenu14507 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addSubMenu14508 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;");
			global::android.view.SubMenu_._addIntentOptions14509 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I");
			global::android.view.SubMenu_._removeItem14510 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "removeItem", "(I)V");
			global::android.view.SubMenu_._removeGroup14511 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "removeGroup", "(I)V");
			global::android.view.SubMenu_._setGroupCheckable14512 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setGroupCheckable", "(IZZ)V");
			global::android.view.SubMenu_._setGroupVisible14513 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setGroupVisible", "(IZ)V");
			global::android.view.SubMenu_._setGroupEnabled14514 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setGroupEnabled", "(IZ)V");
			global::android.view.SubMenu_._hasVisibleItems14515 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "hasVisibleItems", "()Z");
			global::android.view.SubMenu_._findItem14516 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._getItem14517 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;");
			global::android.view.SubMenu_._performShortcut14518 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z");
			global::android.view.SubMenu_._performIdentifierAction14519 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "performIdentifierAction", "(II)Z");
			global::android.view.SubMenu_._setQwertyMode14520 = @__env.GetMethodIDNoThrow(global::android.view.SubMenu_.staticClass, "setQwertyMode", "(Z)V");
		}
	}
}
