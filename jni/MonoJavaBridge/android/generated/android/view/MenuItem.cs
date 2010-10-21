namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.MenuItem_))]
	public interface MenuItem  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class MenuItem_ : java.lang.Object, MenuItem
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MenuItem_()
		{
			InitJNI();
		}
		internal MenuItem_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isChecked14280;
		 bool android.view.MenuItem.isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isChecked14280);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isChecked14280);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked14281;
		 global::android.view.MenuItem android.view.MenuItem.setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setChecked14281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setChecked14281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled14282;
		 bool android.view.MenuItem.isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isEnabled14282);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isEnabled14282);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled14283;
		 global::android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setEnabled14283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setEnabled14283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent14284;
		 global::android.content.Intent android.view.MenuItem.getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIntent14284)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getIntent14284)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible14285;
		 global::android.view.MenuItem android.view.MenuItem.setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setVisible14285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setVisible14285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isVisible14286;
		 bool android.view.MenuItem.isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isVisible14286);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isVisible14286);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent14287;
		 global::android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIntent14287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIntent14287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle14288;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle14288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitle14288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle14289;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle14289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitle14289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitle14290;
		 global::java.lang.CharSequence android.view.MenuItem.getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitle14290)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getTitle14290)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId14291;
		 int android.view.MenuItem.getItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getItemId14291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getItemId14291);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId14292;
		 int android.view.MenuItem.getGroupId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getGroupId14292);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getGroupId14292);
		}
		internal static global::MonoJavaBridge.MethodId _getOrder14293;
		 int android.view.MenuItem.getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getOrder14293);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getOrder14293);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleCondensed14294;
		 global::android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitleCondensed14294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitleCondensed14294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitleCondensed14295;
		 global::java.lang.CharSequence android.view.MenuItem.getTitleCondensed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitleCondensed14295)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getTitleCondensed14295)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon14296;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon14296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIcon14296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon14297;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon14297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIcon14297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIcon14298;
		 global::android.graphics.drawable.Drawable android.view.MenuItem.getIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIcon14298)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getIcon14298)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setShortcut14299;
		 global::android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setShortcut14299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setShortcut14299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setNumericShortcut14300;
		 global::android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setNumericShortcut14300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setNumericShortcut14300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericShortcut14301;
		 char android.view.MenuItem.getNumericShortcut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getNumericShortcut14301);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getNumericShortcut14301);
		}
		internal static global::MonoJavaBridge.MethodId _setAlphabeticShortcut14302;
		 global::android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setAlphabeticShortcut14302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setAlphabeticShortcut14302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getAlphabeticShortcut14303;
		 char android.view.MenuItem.getAlphabeticShortcut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getAlphabeticShortcut14303);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getAlphabeticShortcut14303);
		}
		internal static global::MonoJavaBridge.MethodId _setCheckable14304;
		 global::android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setCheckable14304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setCheckable14304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isCheckable14305;
		 bool android.view.MenuItem.isCheckable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isCheckable14305);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isCheckable14305);
		}
		internal static global::MonoJavaBridge.MethodId _hasSubMenu14306;
		 bool android.view.MenuItem.hasSubMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._hasSubMenu14306);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._hasSubMenu14306);
		}
		internal static global::MonoJavaBridge.MethodId _getSubMenu14307;
		 global::android.view.SubMenu android.view.MenuItem.getSubMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getSubMenu14307)) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getSubMenu14307)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setOnMenuItemClickListener14308;
		 global::android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setOnMenuItemClickListener14308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setOnMenuItemClickListener14308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInfo14309;
		 global::android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getMenuInfo14309)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getMenuInfo14309)) as android.view.ContextMenu_ContextMenuInfo;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem"));
			global::android.view.MenuItem_._isChecked14280 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isChecked", "()Z");
			global::android.view.MenuItem_._setChecked14281 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setChecked", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isEnabled14282 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isEnabled", "()Z");
			global::android.view.MenuItem_._setEnabled14283 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setEnabled", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getIntent14284 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.view.MenuItem_._setVisible14285 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setVisible", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isVisible14286 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isVisible", "()Z");
			global::android.view.MenuItem_._setIntent14287 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setTitle14288 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(I)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setTitle14289 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getTitle14290 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.view.MenuItem_._getItemId14291 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getItemId", "()I");
			global::android.view.MenuItem_._getGroupId14292 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getGroupId", "()I");
			global::android.view.MenuItem_._getOrder14293 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getOrder", "()I");
			global::android.view.MenuItem_._setTitleCondensed14294 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getTitleCondensed14295 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitleCondensed", "()Ljava/lang/CharSequence;");
			global::android.view.MenuItem_._setIcon14296 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setIcon14297 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(I)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getIcon14298 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.MenuItem_._setShortcut14299 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setShortcut", "(CC)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setNumericShortcut14300 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setNumericShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getNumericShortcut14301 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getNumericShortcut", "()C");
			global::android.view.MenuItem_._setAlphabeticShortcut14302 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getAlphabeticShortcut14303 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getAlphabeticShortcut", "()C");
			global::android.view.MenuItem_._setCheckable14304 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setCheckable", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isCheckable14305 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isCheckable", "()Z");
			global::android.view.MenuItem_._hasSubMenu14306 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "hasSubMenu", "()Z");
			global::android.view.MenuItem_._getSubMenu14307 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getSubMenu", "()Landroid/view/SubMenu;");
			global::android.view.MenuItem_._setOnMenuItemClickListener14308 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getMenuInfo14309 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
		}
	}
}
