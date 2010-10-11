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
		internal static global::MonoJavaBridge.MethodId _isChecked8887;
		 bool android.view.MenuItem.isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isChecked8887);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isChecked8887);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked8888;
		 global::android.view.MenuItem android.view.MenuItem.setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setChecked8888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setChecked8888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled8889;
		 bool android.view.MenuItem.isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isEnabled8889);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isEnabled8889);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled8890;
		 global::android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setEnabled8890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setEnabled8890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent8891;
		 global::android.content.Intent android.view.MenuItem.getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIntent8891)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getIntent8891)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible8892;
		 global::android.view.MenuItem android.view.MenuItem.setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setVisible8892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setVisible8892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isVisible8893;
		 bool android.view.MenuItem.isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isVisible8893);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isVisible8893);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent8894;
		 global::android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIntent8894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIntent8894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle8895;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle8895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitle8895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle8896;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle8896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitle8896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitle8897;
		 global::java.lang.CharSequence android.view.MenuItem.getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitle8897)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getTitle8897)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId8898;
		 int android.view.MenuItem.getItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getItemId8898);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getItemId8898);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId8899;
		 int android.view.MenuItem.getGroupId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getGroupId8899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getGroupId8899);
		}
		internal static global::MonoJavaBridge.MethodId _getOrder8900;
		 int android.view.MenuItem.getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getOrder8900);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getOrder8900);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleCondensed8901;
		 global::android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitleCondensed8901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitleCondensed8901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitleCondensed8902;
		 global::java.lang.CharSequence android.view.MenuItem.getTitleCondensed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitleCondensed8902)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getTitleCondensed8902)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon8903;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon8903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIcon8903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon8904;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon8904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIcon8904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIcon8905;
		 global::android.graphics.drawable.Drawable android.view.MenuItem.getIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIcon8905)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getIcon8905)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setShortcut8906;
		 global::android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setShortcut8906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setShortcut8906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setNumericShortcut8907;
		 global::android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setNumericShortcut8907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setNumericShortcut8907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericShortcut8908;
		 char android.view.MenuItem.getNumericShortcut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getNumericShortcut8908);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getNumericShortcut8908);
		}
		internal static global::MonoJavaBridge.MethodId _setAlphabeticShortcut8909;
		 global::android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setAlphabeticShortcut8909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setAlphabeticShortcut8909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getAlphabeticShortcut8910;
		 char android.view.MenuItem.getAlphabeticShortcut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getAlphabeticShortcut8910);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getAlphabeticShortcut8910);
		}
		internal static global::MonoJavaBridge.MethodId _setCheckable8911;
		 global::android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setCheckable8911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setCheckable8911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isCheckable8912;
		 bool android.view.MenuItem.isCheckable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isCheckable8912);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isCheckable8912);
		}
		internal static global::MonoJavaBridge.MethodId _hasSubMenu8913;
		 bool android.view.MenuItem.hasSubMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._hasSubMenu8913);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._hasSubMenu8913);
		}
		internal static global::MonoJavaBridge.MethodId _getSubMenu8914;
		 global::android.view.SubMenu android.view.MenuItem.getSubMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getSubMenu8914)) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getSubMenu8914)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setOnMenuItemClickListener8915;
		 global::android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setOnMenuItemClickListener8915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setOnMenuItemClickListener8915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInfo8916;
		 global::android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getMenuInfo8916)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getMenuInfo8916)) as android.view.ContextMenu_ContextMenuInfo;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem"));
			global::android.view.MenuItem_._isChecked8887 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isChecked", "()Z");
			global::android.view.MenuItem_._setChecked8888 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setChecked", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isEnabled8889 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isEnabled", "()Z");
			global::android.view.MenuItem_._setEnabled8890 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setEnabled", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getIntent8891 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.view.MenuItem_._setVisible8892 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setVisible", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isVisible8893 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isVisible", "()Z");
			global::android.view.MenuItem_._setIntent8894 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setTitle8895 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(I)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setTitle8896 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getTitle8897 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.view.MenuItem_._getItemId8898 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getItemId", "()I");
			global::android.view.MenuItem_._getGroupId8899 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getGroupId", "()I");
			global::android.view.MenuItem_._getOrder8900 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getOrder", "()I");
			global::android.view.MenuItem_._setTitleCondensed8901 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getTitleCondensed8902 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitleCondensed", "()Ljava/lang/CharSequence;");
			global::android.view.MenuItem_._setIcon8903 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setIcon8904 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(I)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getIcon8905 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.MenuItem_._setShortcut8906 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setShortcut", "(CC)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setNumericShortcut8907 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setNumericShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getNumericShortcut8908 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getNumericShortcut", "()C");
			global::android.view.MenuItem_._setAlphabeticShortcut8909 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getAlphabeticShortcut8910 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getAlphabeticShortcut", "()C");
			global::android.view.MenuItem_._setCheckable8911 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setCheckable", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isCheckable8912 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isCheckable", "()Z");
			global::android.view.MenuItem_._hasSubMenu8913 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "hasSubMenu", "()Z");
			global::android.view.MenuItem_._getSubMenu8914 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getSubMenu", "()Landroid/view/SubMenu;");
			global::android.view.MenuItem_._setOnMenuItemClickListener8915 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getMenuInfo8916 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
		}
	}
}
