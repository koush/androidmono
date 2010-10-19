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
		internal static global::MonoJavaBridge.MethodId _isChecked9433;
		 bool android.view.MenuItem.isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isChecked9433);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isChecked9433);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked9434;
		 global::android.view.MenuItem android.view.MenuItem.setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setChecked9434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setChecked9434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled9435;
		 bool android.view.MenuItem.isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isEnabled9435);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isEnabled9435);
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled9436;
		 global::android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setEnabled9436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setEnabled9436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent9437;
		 global::android.content.Intent android.view.MenuItem.getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIntent9437)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getIntent9437)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible9438;
		 global::android.view.MenuItem android.view.MenuItem.setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setVisible9438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setVisible9438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isVisible9439;
		 bool android.view.MenuItem.isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isVisible9439);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isVisible9439);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent9440;
		 global::android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIntent9440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIntent9440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle9441;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle9441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitle9441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle9442;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitle9442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitle9442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitle9443;
		 global::java.lang.CharSequence android.view.MenuItem.getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitle9443)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getTitle9443)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId9444;
		 int android.view.MenuItem.getItemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getItemId9444);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getItemId9444);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId9445;
		 int android.view.MenuItem.getGroupId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getGroupId9445);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getGroupId9445);
		}
		internal static global::MonoJavaBridge.MethodId _getOrder9446;
		 int android.view.MenuItem.getOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MenuItem_._getOrder9446);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getOrder9446);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleCondensed9447;
		 global::android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setTitleCondensed9447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setTitleCondensed9447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTitleCondensed9448;
		 global::java.lang.CharSequence android.view.MenuItem.getTitleCondensed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getTitleCondensed9448)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getTitleCondensed9448)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon9449;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon9449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIcon9449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setIcon9450;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setIcon9450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setIcon9450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getIcon9451;
		 global::android.graphics.drawable.Drawable android.view.MenuItem.getIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getIcon9451)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getIcon9451)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setShortcut9452;
		 global::android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setShortcut9452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setShortcut9452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _setNumericShortcut9453;
		 global::android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setNumericShortcut9453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setNumericShortcut9453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericShortcut9454;
		 char android.view.MenuItem.getNumericShortcut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getNumericShortcut9454);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getNumericShortcut9454);
		}
		internal static global::MonoJavaBridge.MethodId _setAlphabeticShortcut9455;
		 global::android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setAlphabeticShortcut9455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setAlphabeticShortcut9455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getAlphabeticShortcut9456;
		 char android.view.MenuItem.getAlphabeticShortcut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.view.MenuItem_._getAlphabeticShortcut9456);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getAlphabeticShortcut9456);
		}
		internal static global::MonoJavaBridge.MethodId _setCheckable9457;
		 global::android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setCheckable9457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setCheckable9457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _isCheckable9458;
		 bool android.view.MenuItem.isCheckable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._isCheckable9458);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._isCheckable9458);
		}
		internal static global::MonoJavaBridge.MethodId _hasSubMenu9459;
		 bool android.view.MenuItem.hasSubMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_._hasSubMenu9459);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._hasSubMenu9459);
		}
		internal static global::MonoJavaBridge.MethodId _getSubMenu9460;
		 global::android.view.SubMenu android.view.MenuItem.getSubMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getSubMenu9460)) as android.view.SubMenu;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SubMenu>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getSubMenu9460)) as android.view.SubMenu;
		}
		internal static global::MonoJavaBridge.MethodId _setOnMenuItemClickListener9461;
		 global::android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._setOnMenuItemClickListener9461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.MenuItem>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._setOnMenuItemClickListener9461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MenuItem;
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInfo9462;
		 global::android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MenuItem_._getMenuInfo9462)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MenuItem_.staticClass, global::android.view.MenuItem_._getMenuInfo9462)) as android.view.ContextMenu_ContextMenuInfo;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem"));
			global::android.view.MenuItem_._isChecked9433 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isChecked", "()Z");
			global::android.view.MenuItem_._setChecked9434 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setChecked", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isEnabled9435 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isEnabled", "()Z");
			global::android.view.MenuItem_._setEnabled9436 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setEnabled", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getIntent9437 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.view.MenuItem_._setVisible9438 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setVisible", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isVisible9439 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isVisible", "()Z");
			global::android.view.MenuItem_._setIntent9440 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setTitle9441 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(I)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setTitle9442 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getTitle9443 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.view.MenuItem_._getItemId9444 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getItemId", "()I");
			global::android.view.MenuItem_._getGroupId9445 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getGroupId", "()I");
			global::android.view.MenuItem_._getOrder9446 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getOrder", "()I");
			global::android.view.MenuItem_._setTitleCondensed9447 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getTitleCondensed9448 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getTitleCondensed", "()Ljava/lang/CharSequence;");
			global::android.view.MenuItem_._setIcon9449 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setIcon9450 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setIcon", "(I)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getIcon9451 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.MenuItem_._setShortcut9452 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setShortcut", "(CC)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._setNumericShortcut9453 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setNumericShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getNumericShortcut9454 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getNumericShortcut", "()C");
			global::android.view.MenuItem_._setAlphabeticShortcut9455 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getAlphabeticShortcut9456 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getAlphabeticShortcut", "()C");
			global::android.view.MenuItem_._setCheckable9457 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setCheckable", "(Z)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._isCheckable9458 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "isCheckable", "()Z");
			global::android.view.MenuItem_._hasSubMenu9459 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "hasSubMenu", "()Z");
			global::android.view.MenuItem_._getSubMenu9460 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getSubMenu", "()Landroid/view/SubMenu;");
			global::android.view.MenuItem_._setOnMenuItemClickListener9461 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			global::android.view.MenuItem_._getMenuInfo9462 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_.staticClass, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
		}
	}
}
