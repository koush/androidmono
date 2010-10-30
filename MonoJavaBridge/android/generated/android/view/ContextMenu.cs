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
		internal ContextMenu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu>(this, global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/ContextMenu;", ref global::android.view.ContextMenu_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ContextMenu;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::android.view.ContextMenu android.view.ContextMenu.setHeaderTitle(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu>(this, global::android.view.ContextMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;", ref global::android.view.ContextMenu_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ContextMenu;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu>(this, global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/ContextMenu;", ref global::android.view.ContextMenu_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ContextMenu;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::android.view.ContextMenu android.view.ContextMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu>(this, global::android.view.ContextMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;", ref global::android.view.ContextMenu_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ContextMenu;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::android.view.ContextMenu android.view.ContextMenu.setHeaderView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu>(this, global::android.view.ContextMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;", ref global::android.view.ContextMenu_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ContextMenu;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void android.view.ContextMenu.clearHeader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "clearHeader", "()V", ref global::android.view.ContextMenu_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::android.view.MenuItem android.view.Menu.add(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.ContextMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;", ref global::android.view.ContextMenu_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.ContextMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.ContextMenu_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.ContextMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;", ref global::android.view.ContextMenu_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.ContextMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.ContextMenu_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void android.view.Menu.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "clear", "()V", ref global::android.view.ContextMenu_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int android.view.Menu.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ContextMenu_.staticClass, "size", "()I", ref global::android.view.ContextMenu_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void android.view.Menu.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "close", "()V", ref global::android.view.ContextMenu_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ContextMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.ContextMenu_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.ContextMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.ContextMenu_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.ContextMenu_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.ContextMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;", ref global::android.view.ContextMenu_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.ContextMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;", ref global::android.view.ContextMenu_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ContextMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I", ref global::android.view.ContextMenu_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void android.view.Menu.removeItem(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "removeItem", "(I)V", ref global::android.view.ContextMenu_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void android.view.Menu.removeGroup(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "removeGroup", "(I)V", ref global::android.view.ContextMenu_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "setGroupCheckable", "(IZZ)V", ref global::android.view.ContextMenu_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void android.view.Menu.setGroupVisible(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "setGroupVisible", "(IZ)V", ref global::android.view.ContextMenu_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void android.view.Menu.setGroupEnabled(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "setGroupEnabled", "(IZ)V", ref global::android.view.ContextMenu_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		bool android.view.Menu.hasVisibleItems()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ContextMenu_.staticClass, "hasVisibleItems", "()Z", ref global::android.view.ContextMenu_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::android.view.MenuItem android.view.Menu.findItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.ContextMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;", ref global::android.view.ContextMenu_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::android.view.MenuItem android.view.Menu.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.ContextMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;", ref global::android.view.ContextMenu_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ContextMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z", ref global::android.view.ContextMenu_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		bool android.view.Menu.performIdentifierAction(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ContextMenu_.staticClass, "performIdentifierAction", "(II)Z", ref global::android.view.ContextMenu_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void android.view.Menu.setQwertyMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextMenu_.staticClass, "setQwertyMode", "(Z)V", ref global::android.view.ContextMenu_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ContextMenu_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextMenu"));
		}
		internal static void InitJNI()
		{
		}
	}
}
