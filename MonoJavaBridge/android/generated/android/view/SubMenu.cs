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
		internal SubMenu_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.view.MenuItem android.view.SubMenu.getItem()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "getItem", "()Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m0) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::android.view.SubMenu android.view.SubMenu.setIcon(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::android.view.SubMenu android.view.SubMenu.setIcon(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setIcon", "(I)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setHeaderTitle", "(I)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::android.view.SubMenu android.view.SubMenu.setHeaderTitle(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::android.view.SubMenu android.view.SubMenu.setHeaderIcon(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setHeaderIcon", "(I)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::android.view.SubMenu android.view.SubMenu.setHeaderView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void android.view.SubMenu.clearHeader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "clearHeader", "()V", ref global::android.view.SubMenu_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::android.view.MenuItem android.view.Menu.add(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "add", "(I)Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::android.view.MenuItem android.view.Menu.add(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "add", "(IIII)Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::android.view.MenuItem android.view.Menu.add(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void android.view.Menu.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "clear", "()V", ref global::android.view.SubMenu_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		int android.view.Menu.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.SubMenu_.staticClass, "size", "()I", ref global::android.view.SubMenu_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void android.view.Menu.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "close", "()V", ref global::android.view.SubMenu_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool android.view.Menu.isShortcutKey(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SubMenu_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.SubMenu_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::android.view.SubMenu android.view.Menu.addSubMenu(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "addSubMenu", "(I)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::android.view.SubMenu android.view.Menu.addSubMenu(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.SubMenu_.staticClass, "addSubMenu", "(IIII)Landroid/view/SubMenu;", ref global::android.view.SubMenu_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		int android.view.Menu.addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.SubMenu_.staticClass, "addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I", ref global::android.view.SubMenu_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void android.view.Menu.removeItem(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "removeItem", "(I)V", ref global::android.view.SubMenu_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void android.view.Menu.removeGroup(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "removeGroup", "(I)V", ref global::android.view.SubMenu_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void android.view.Menu.setGroupCheckable(int arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "setGroupCheckable", "(IZZ)V", ref global::android.view.SubMenu_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void android.view.Menu.setGroupVisible(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "setGroupVisible", "(IZ)V", ref global::android.view.SubMenu_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void android.view.Menu.setGroupEnabled(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "setGroupEnabled", "(IZ)V", ref global::android.view.SubMenu_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		bool android.view.Menu.hasVisibleItems()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SubMenu_.staticClass, "hasVisibleItems", "()Z", ref global::android.view.SubMenu_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::android.view.MenuItem android.view.Menu.findItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "findItem", "(I)Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::android.view.MenuItem android.view.Menu.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.SubMenu_.staticClass, "getItem", "(I)Landroid/view/MenuItem;", ref global::android.view.SubMenu_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool android.view.Menu.performShortcut(int arg0, android.view.KeyEvent arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SubMenu_.staticClass, "performShortcut", "(ILandroid/view/KeyEvent;I)Z", ref global::android.view.SubMenu_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		bool android.view.Menu.performIdentifierAction(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SubMenu_.staticClass, "performIdentifierAction", "(II)Z", ref global::android.view.SubMenu_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void android.view.Menu.setQwertyMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SubMenu_.staticClass, "setQwertyMode", "(Z)V", ref global::android.view.SubMenu_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SubMenu_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SubMenu_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SubMenu"));
		}
	}
}
