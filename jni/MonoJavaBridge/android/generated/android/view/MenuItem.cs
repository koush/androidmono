namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface MenuItem 
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

	public partial class MenuItem_
	{
		public static global::java.lang.Class _class
		{
			get { return __MenuItem.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __MenuItem : java.lang.Object, MenuItem
	{
		internal static global::java.lang.Class staticClass;
		static __MenuItem()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__MenuItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.__MenuItem(@__env);
			}
		}
		internal __MenuItem(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked8581;
		 bool android.view.MenuItem.isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__MenuItem._isChecked8581);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._isChecked8581);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked8582;
		 global::android.view.MenuItem android.view.MenuItem.setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setChecked8582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setChecked8582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled8583;
		 bool android.view.MenuItem.isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__MenuItem._isEnabled8583);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._isEnabled8583);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled8584;
		 global::android.view.MenuItem android.view.MenuItem.setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setEnabled8584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setEnabled8584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntent8585;
		 global::android.content.Intent android.view.MenuItem.getIntent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._getIntent8585));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getIntent8585));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible8586;
		 global::android.view.MenuItem android.view.MenuItem.setVisible(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setVisible8586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setVisible8586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVisible8587;
		 bool android.view.MenuItem.isVisible() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__MenuItem._isVisible8587);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._isVisible8587);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntent8588;
		 global::android.view.MenuItem android.view.MenuItem.setIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setIntent8588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setIntent8588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle8589;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setTitle8589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setTitle8589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle8590;
		 global::android.view.MenuItem android.view.MenuItem.setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setTitle8590, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setTitle8590, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle8591;
		 global::java.lang.CharSequence android.view.MenuItem.getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._getTitle8591));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getTitle8591));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId8592;
		 int android.view.MenuItem.getItemId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__MenuItem._getItemId8592);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getItemId8592);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId8593;
		 int android.view.MenuItem.getGroupId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__MenuItem._getGroupId8593);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getGroupId8593);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrder8594;
		 int android.view.MenuItem.getOrder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.__MenuItem._getOrder8594);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getOrder8594);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitleCondensed8595;
		 global::android.view.MenuItem android.view.MenuItem.setTitleCondensed(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setTitleCondensed8595, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setTitleCondensed8595, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitleCondensed8596;
		 global::java.lang.CharSequence android.view.MenuItem.getTitleCondensed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._getTitleCondensed8596));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getTitleCondensed8596));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon8597;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setIcon8597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setIcon8597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon8598;
		 global::android.view.MenuItem android.view.MenuItem.setIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setIcon8598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setIcon8598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIcon8599;
		 global::android.graphics.drawable.Drawable android.view.MenuItem.getIcon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._getIcon8599));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getIcon8599));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShortcut8600;
		 global::android.view.MenuItem android.view.MenuItem.setShortcut(char arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setShortcut8600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setShortcut8600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNumericShortcut8601;
		 global::android.view.MenuItem android.view.MenuItem.setNumericShortcut(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setNumericShortcut8601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setNumericShortcut8601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumericShortcut8602;
		 char android.view.MenuItem.getNumericShortcut() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.view.__MenuItem._getNumericShortcut8602);
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getNumericShortcut8602);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlphabeticShortcut8603;
		 global::android.view.MenuItem android.view.MenuItem.setAlphabeticShortcut(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setAlphabeticShortcut8603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setAlphabeticShortcut8603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlphabeticShortcut8604;
		 char android.view.MenuItem.getAlphabeticShortcut() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.view.__MenuItem._getAlphabeticShortcut8604);
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getAlphabeticShortcut8604);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCheckable8605;
		 global::android.view.MenuItem android.view.MenuItem.setCheckable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setCheckable8605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setCheckable8605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCheckable8606;
		 bool android.view.MenuItem.isCheckable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__MenuItem._isCheckable8606);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._isCheckable8606);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasSubMenu8607;
		 bool android.view.MenuItem.hasSubMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__MenuItem._hasSubMenu8607);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._hasSubMenu8607);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubMenu8608;
		 global::android.view.SubMenu android.view.MenuItem.getSubMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._getSubMenu8608));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SubMenu>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getSubMenu8608));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnMenuItemClickListener8609;
		 global::android.view.MenuItem android.view.MenuItem.setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._setOnMenuItemClickListener8609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.MenuItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._setOnMenuItemClickListener8609, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMenuInfo8610;
		 global::android.view.ContextMenu_ContextMenuInfo android.view.MenuItem.getMenuInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__MenuItem._getMenuInfo8610));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__MenuItem.staticClass, global::android.view.__MenuItem._getMenuInfo8610));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__MenuItem.staticClass = @__class;
			global::android.view.__MenuItem._isChecked8581 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isChecked", "()Z");
			global::android.view.__MenuItem._setChecked8582 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setChecked", "(Z)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._isEnabled8583 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isEnabled", "()Z");
			global::android.view.__MenuItem._setEnabled8584 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setEnabled", "(Z)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getIntent8585 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getIntent", "()Landroid/content/Intent;");
			global::android.view.__MenuItem._setVisible8586 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setVisible", "(Z)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._isVisible8587 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isVisible", "()Z");
			global::android.view.__MenuItem._setIntent8588 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._setTitle8589 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setTitle", "(I)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._setTitle8590 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getTitle8591 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getTitle", "()Ljava/lang/CharSequence;");
			global::android.view.__MenuItem._getItemId8592 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getItemId", "()I");
			global::android.view.__MenuItem._getGroupId8593 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getGroupId", "()I");
			global::android.view.__MenuItem._getOrder8594 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getOrder", "()I");
			global::android.view.__MenuItem._setTitleCondensed8595 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getTitleCondensed8596 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getTitleCondensed", "()Ljava/lang/CharSequence;");
			global::android.view.__MenuItem._setIcon8597 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._setIcon8598 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setIcon", "(I)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getIcon8599 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.view.__MenuItem._setShortcut8600 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setShortcut", "(CC)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._setNumericShortcut8601 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setNumericShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getNumericShortcut8602 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getNumericShortcut", "()C");
			global::android.view.__MenuItem._setAlphabeticShortcut8603 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getAlphabeticShortcut8604 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getAlphabeticShortcut", "()C");
			global::android.view.__MenuItem._setCheckable8605 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setCheckable", "(Z)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._isCheckable8606 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.isCheckable", "()Z");
			global::android.view.__MenuItem._hasSubMenu8607 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.hasSubMenu", "()Z");
			global::android.view.__MenuItem._getSubMenu8608 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getSubMenu", "()Landroid/view/SubMenu;");
			global::android.view.__MenuItem._setOnMenuItemClickListener8609 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			global::android.view.__MenuItem._getMenuInfo8610 = @__env.GetMethodID(global::android.view.__MenuItem.staticClass, "android.view.MenuItem.getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
		}
	}
}
