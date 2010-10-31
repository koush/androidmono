namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.MenuItem_))]
	public partial interface MenuItem  : global::MonoJavaBridge.IJavaObject 
	{
		bool isChecked();
		global::android.view.MenuItem setChecked(bool arg0);
		bool isEnabled();
		global::android.view.MenuItem setEnabled(bool arg0);
		global::android.content.Intent getIntent();
		global::android.view.MenuItem setVisible(bool arg0);
		bool isVisible();
		global::android.view.MenuItem setIntent(android.content.Intent arg0);
		global::android.view.MenuItem setTitle(int arg0);
		global::android.view.MenuItem setTitle(java.lang.CharSequence arg0);
		global::java.lang.CharSequence getTitle();
		int getItemId();
		int getGroupId();
		int getOrder();
		global::android.view.MenuItem setTitleCondensed(java.lang.CharSequence arg0);
		global::java.lang.CharSequence getTitleCondensed();
		global::android.view.MenuItem setIcon(android.graphics.drawable.Drawable arg0);
		global::android.view.MenuItem setIcon(int arg0);
		global::android.graphics.drawable.Drawable getIcon();
		global::android.view.MenuItem setShortcut(char arg0, char arg1);
		global::android.view.MenuItem setNumericShortcut(char arg0);
		char getNumericShortcut();
		global::android.view.MenuItem setAlphabeticShortcut(char arg0);
		char getAlphabeticShortcut();
		global::android.view.MenuItem setCheckable(bool arg0);
		bool isCheckable();
		bool hasSubMenu();
		global::android.view.SubMenu getSubMenu();
		global::android.view.MenuItem setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0);
		global::android.view.ContextMenu_ContextMenuInfo getMenuInfo();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.MenuItem))]
	internal sealed partial class MenuItem_ : java.lang.Object, MenuItem
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MenuItem_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.view.MenuItem.isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.MenuItem_.staticClass, "isChecked", "()Z", ref global::android.view.MenuItem_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::android.view.MenuItem android.view.MenuItem.setChecked(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setChecked", "(Z)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool android.view.MenuItem.isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.MenuItem_.staticClass, "isEnabled", "()Z", ref global::android.view.MenuItem_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setEnabled", "(Z)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::android.content.Intent android.view.MenuItem.getIntent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.MenuItem_.staticClass, "getIntent", "()Landroid/content/Intent;", ref global::android.view.MenuItem_._m4) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::android.view.MenuItem android.view.MenuItem.setVisible(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setVisible", "(Z)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool android.view.MenuItem.isVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.MenuItem_.staticClass, "isVisible", "()Z", ref global::android.view.MenuItem_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::android.view.MenuItem android.view.MenuItem.setTitle(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setTitle", "(I)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.CharSequence android.view.MenuItem.getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.MenuItem_.staticClass, "getTitle", "()Ljava/lang/CharSequence;", ref global::android.view.MenuItem_._m10) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int android.view.MenuItem.getItemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MenuItem_.staticClass, "getItemId", "()I", ref global::android.view.MenuItem_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int android.view.MenuItem.getGroupId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MenuItem_.staticClass, "getGroupId", "()I", ref global::android.view.MenuItem_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int android.view.MenuItem.getOrder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MenuItem_.staticClass, "getOrder", "()I", ref global::android.view.MenuItem_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.CharSequence android.view.MenuItem.getTitleCondensed()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.MenuItem_.staticClass, "getTitleCondensed", "()Ljava/lang/CharSequence;", ref global::android.view.MenuItem_._m15) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::android.view.MenuItem android.view.MenuItem.setIcon(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setIcon", "(I)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::android.graphics.drawable.Drawable android.view.MenuItem.getIcon()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.MenuItem_.staticClass, "getIcon", "()Landroid/graphics/drawable/Drawable;", ref global::android.view.MenuItem_._m18) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setShortcut", "(CC)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setNumericShortcut", "(C)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		char android.view.MenuItem.getNumericShortcut()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.MenuItem_.staticClass, "getNumericShortcut", "()C", ref global::android.view.MenuItem_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		char android.view.MenuItem.getAlphabeticShortcut()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.view.MenuItem_.staticClass, "getAlphabeticShortcut", "()C", ref global::android.view.MenuItem_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setCheckable", "(Z)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		bool android.view.MenuItem.isCheckable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.MenuItem_.staticClass, "isCheckable", "()Z", ref global::android.view.MenuItem_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		bool android.view.MenuItem.hasSubMenu()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.MenuItem_.staticClass, "hasSubMenu", "()Z", ref global::android.view.MenuItem_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		global::android.view.SubMenu android.view.MenuItem.getSubMenu()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SubMenu>(this, global::android.view.MenuItem_.staticClass, "getSubMenu", "()Landroid/view/SubMenu;", ref global::android.view.MenuItem_._m27) as android.view.SubMenu;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.MenuItem>(this, global::android.view.MenuItem_.staticClass, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;", ref global::android.view.MenuItem_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.MenuItem;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.view.MenuItem_.staticClass, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.view.MenuItem_._m29) as android.view.ContextMenu_ContextMenuInfo;
		}
		static MenuItem_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem"));
		}
	}
}
