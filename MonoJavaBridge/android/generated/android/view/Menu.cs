namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.Menu_))]
	public partial interface Menu  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.view.MenuItem add(int arg0);
		global::android.view.MenuItem add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3);
		global::android.view.MenuItem add(int arg0, int arg1, int arg2, int arg3);
		global::android.view.MenuItem add(java.lang.CharSequence arg0);
		void clear();
		int size();
		void close();
		bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		global::android.view.SubMenu addSubMenu(java.lang.CharSequence arg0);
		global::android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3);
		global::android.view.SubMenu addSubMenu(int arg0);
		global::android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, int arg3);
		int addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7);
		void removeItem(int arg0);
		void removeGroup(int arg0);
		void setGroupCheckable(int arg0, bool arg1, bool arg2);
		void setGroupVisible(int arg0, bool arg1);
		void setGroupEnabled(int arg0, bool arg1);
		bool hasVisibleItems();
		global::android.view.MenuItem findItem(int arg0);
		global::android.view.MenuItem getItem(int arg0);
		bool performShortcut(int arg0, android.view.KeyEvent arg1, int arg2);
		bool performIdentifierAction(int arg0, int arg1);
		void setQwertyMode(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Menu))]
	internal sealed partial class Menu_ : java.lang.Object, Menu
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Menu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add14311;
		global::android.view.MenuItem android.view.Menu.add(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.Menu_.staticClass, "add", "(I)Landroid/view/MenuItem;", ref global::android.view.Menu_._add14311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add14312;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.Menu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.Menu_._add14312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add14313;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.Menu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;", ref global::android.view.Menu_._add14313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _add14314;
		global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.Menu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.Menu_._add14314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _clear14315;
		void android.view.Menu.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "clear", "()V", ref global::android.view.Menu_._clear14315);
		}
		internal static global::MonoJavaBridge.MethodId _size14316;
		int android.view.Menu.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Menu_.staticClass, "size", "()I", ref global::android.view.Menu_._size14316);
		}
		internal static global::MonoJavaBridge.MethodId _close14317;
		void android.view.Menu.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "close", "()V", ref global::android.view.Menu_._close14317);
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey14318;
		bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Menu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.Menu_._isShortcutKey14318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14319;
		global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.Menu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.Menu_._addSubMenu14319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14320;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.Menu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.Menu_._addSubMenu14320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14321;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.Menu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;", ref global::android.view.Menu_._addSubMenu14321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addSubMenu14322;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.Menu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;", ref global::android.view.Menu_._addSubMenu14322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _addIntentOptions14323;
		int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Menu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I", ref global::android.view.Menu_._addIntentOptions14323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _removeItem14324;
		void android.view.Menu.removeItem(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "removeItem", "(I)V", ref global::android.view.Menu_._removeItem14324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGroup14325;
		void android.view.Menu.removeGroup(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "removeGroup", "(I)V", ref global::android.view.Menu_._removeGroup14325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupCheckable14326;
		void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "setGroupCheckable", "(IZZ)V", ref global::android.view.Menu_._setGroupCheckable14326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupVisible14327;
		void android.view.Menu.setGroupVisible(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "setGroupVisible", "(IZ)V", ref global::android.view.Menu_._setGroupVisible14327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupEnabled14328;
		void android.view.Menu.setGroupEnabled(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "setGroupEnabled", "(IZ)V", ref global::android.view.Menu_._setGroupEnabled14328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasVisibleItems14329;
		bool android.view.Menu.hasVisibleItems()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Menu_.staticClass, "hasVisibleItems", "()Z", ref global::android.view.Menu_._hasVisibleItems14329);
		}
		internal static global::MonoJavaBridge.MethodId _findItem14330;
		global::android.view.MenuItem android.view.Menu.findItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.Menu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;", ref global::android.view.Menu_._findItem14330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getItem14331;
		global::android.view.MenuItem android.view.Menu.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.Menu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;", ref global::android.view.Menu_._getItem14331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _performShortcut14332;
		bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Menu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z", ref global::android.view.Menu_._performShortcut14332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _performIdentifierAction14333;
		bool android.view.Menu.performIdentifierAction(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Menu_.staticClass, "performIdentifierAction", "(II)Z", ref global::android.view.Menu_._performIdentifierAction14333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setQwertyMode14334;
		void android.view.Menu.setQwertyMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Menu_.staticClass, "setQwertyMode", "(Z)V", ref global::android.view.Menu_._setQwertyMode14334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Menu_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Menu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Menu"));
		}
		internal static void InitJNI()
		{
		}
	}
}
