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
		internal static global::MonoJavaBridge.MethodId _isChecked14348;
		bool android.view.MenuItem.isChecked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._isChecked14348.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._isChecked14348 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isChecked", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isChecked14348);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked14349;
		global::android.view.MenuItem android.view.MenuItem.setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setChecked14349.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setChecked14349 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setChecked", "(Z)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setChecked14349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled14350;
		bool android.view.MenuItem.isEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._isEnabled14350.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._isEnabled14350 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isEnabled", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isEnabled14350);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled14351;
		global::android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setEnabled14351.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setEnabled14351 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setEnabled", "(Z)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setEnabled14351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent14352;
		global::android.content.Intent android.view.MenuItem.getIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getIntent14352.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getIntent14352 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIntent", "()Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIntent14352)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible14353;
		global::android.view.MenuItem android.view.MenuItem.setVisible(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setVisible14353.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setVisible14353 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setVisible", "(Z)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setVisible14353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isVisible14354;
		bool android.view.MenuItem.isVisible()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._isVisible14354.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._isVisible14354 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isVisible", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isVisible14354);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent14355;
		global::android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setIntent14355.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setIntent14355 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIntent14355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle14356;
		global::android.view.MenuItem android.view.MenuItem.setTitle(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setTitle14356.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setTitle14356 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(I)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle14356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle14357;
		global::android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setTitle14357.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setTitle14357 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle14357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitle14358;
		global::java.lang.CharSequence android.view.MenuItem.getTitle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getTitle14358.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getTitle14358 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitle14358)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId14359;
		int android.view.MenuItem.getItemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getItemId14359.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getItemId14359 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getItemId", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getItemId14359);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId14360;
		int android.view.MenuItem.getGroupId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getGroupId14360.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getGroupId14360 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getGroupId", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getGroupId14360);
		}
		internal static global::MonoJavaBridge.MethodId _getOrder14361;
		int android.view.MenuItem.getOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getOrder14361.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getOrder14361 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getOrder", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getOrder14361);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleCondensed14362;
		global::android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setTitleCondensed14362.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setTitleCondensed14362 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitleCondensed14362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitleCondensed14363;
		global::java.lang.CharSequence android.view.MenuItem.getTitleCondensed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getTitleCondensed14363.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getTitleCondensed14363 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitleCondensed", "()Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitleCondensed14363)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon14364;
		global::android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setIcon14364.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setIcon14364 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon14364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon14365;
		global::android.view.MenuItem android.view.MenuItem.setIcon(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setIcon14365.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setIcon14365 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(I)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon14365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIcon14366;
		global::android.graphics.drawable.Drawable android.view.MenuItem.getIcon()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getIcon14366.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getIcon14366 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIcon", "()Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIcon14366)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setShortcut14367;
		global::android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setShortcut14367.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setShortcut14367 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setShortcut", "(CC)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setShortcut14367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setNumericShortcut14368;
		global::android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setNumericShortcut14368.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setNumericShortcut14368 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setNumericShortcut", "(C)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setNumericShortcut14368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericShortcut14369;
		char android.view.MenuItem.getNumericShortcut()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getNumericShortcut14369.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getNumericShortcut14369 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getNumericShortcut", "()C");
			return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getNumericShortcut14369);
		}
		internal static global::MonoJavaBridge.MethodId _setAlphabeticShortcut14370;
		global::android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setAlphabeticShortcut14370.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setAlphabeticShortcut14370 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setAlphabeticShortcut14370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getAlphabeticShortcut14371;
		char android.view.MenuItem.getAlphabeticShortcut()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getAlphabeticShortcut14371.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getAlphabeticShortcut14371 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getAlphabeticShortcut", "()C");
			return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getAlphabeticShortcut14371);
		}
		internal static global::MonoJavaBridge.MethodId _setCheckable14372;
		global::android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setCheckable14372.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setCheckable14372 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setCheckable", "(Z)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setCheckable14372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isCheckable14373;
		bool android.view.MenuItem.isCheckable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._isCheckable14373.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._isCheckable14373 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isCheckable", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isCheckable14373);
		}
		internal static global::MonoJavaBridge.MethodId _hasSubMenu14374;
		bool android.view.MenuItem.hasSubMenu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._hasSubMenu14374.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._hasSubMenu14374 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "hasSubMenu", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._hasSubMenu14374);
		}
		internal static global::MonoJavaBridge.MethodId _getSubMenu14375;
		global::android.view.SubMenu android.view.MenuItem.getSubMenu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getSubMenu14375.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getSubMenu14375 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getSubMenu", "()Landroid/view/SubMenu;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getSubMenu14375)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setOnMenuItemClickListener14376;
		global::android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._setOnMenuItemClickListener14376.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._setOnMenuItemClickListener14376 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setOnMenuItemClickListener14376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInfo14377;
		global::android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MenuItem_._getMenuInfo14377.native == global::System.IntPtr.Zero)
				global::android.view.MenuItem_._getMenuInfo14377 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getMenuInfo14377)) as android.view.ContextMenu_ContextMenuInfo;
		}
		static MenuItem_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem"));
		}
		internal static void InitJNI()
		{
		}
	}
}
