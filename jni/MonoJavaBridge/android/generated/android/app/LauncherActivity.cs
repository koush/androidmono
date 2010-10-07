namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class LauncherActivity : android.app.ListActivity
	{
		internal new static global::java.lang.Class staticClass;
		static LauncherActivity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.LauncherActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected LauncherActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class IconResizer : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static IconResizer()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.LauncherActivity.IconResizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.LauncherActivity.IconResizer(@__env);
				}
			}
			protected IconResizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _createIconThumbnail626;
			public virtual global::android.graphics.drawable.Drawable createIconThumbnail(android.graphics.drawable.Drawable arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LauncherActivity.IconResizer._createIconThumbnail626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._createIconThumbnail626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _IconResizer627;
			public IconResizer(android.app.LauncherActivity arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._IconResizer627, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.LauncherActivity.IconResizer.staticClass = @__class;
				global::android.app.LauncherActivity.IconResizer._createIconThumbnail626 = @__env.GetMethodID(global::android.app.LauncherActivity.IconResizer.staticClass, "createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
				global::android.app.LauncherActivity.IconResizer._IconResizer627 = @__env.GetMethodID(global::android.app.LauncherActivity.IconResizer.staticClass, "<init>", "(Landroid/app/LauncherActivity;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class ListItem : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static ListItem()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.LauncherActivity.ListItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.LauncherActivity.ListItem(@__env);
				}
			}
			protected ListItem(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _ListItem628;
			public ListItem()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.LauncherActivity.ListItem.staticClass, global::android.app.LauncherActivity.ListItem._ListItem628, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _resolveInfo629;
			public global::android.content.pm.ResolveInfo resolveInfo
			{
				get
				{
					return default(global::android.content.pm.ResolveInfo);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _label630;
			public global::java.lang.CharSequence label
			{
				get
				{
					return default(global::java.lang.CharSequence);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _icon631;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					return default(global::android.graphics.drawable.Drawable);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _packageName632;
			public global::java.lang.String packageName
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _className633;
			public global::java.lang.String className
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _extras634;
			public global::android.os.Bundle extras
			{
				get
				{
					return default(global::android.os.Bundle);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.LauncherActivity.ListItem.staticClass = @__class;
				global::android.app.LauncherActivity.ListItem._ListItem628 = @__env.GetMethodID(global::android.app.LauncherActivity.ListItem.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate635;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.LauncherActivity._onCreate635, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onCreate635, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetContentView636;
		protected virtual void onSetContentView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.LauncherActivity._onSetContentView636);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onSetContentView636);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onListItemClick637;
		protected override void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.LauncherActivity._onListItemClick637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onListItemClick637, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intentForPosition638;
		protected virtual global::android.content.Intent intentForPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LauncherActivity._intentForPosition638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._intentForPosition638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _itemForPosition639;
		protected virtual global::android.app.LauncherActivity.ListItem itemForPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LauncherActivity.ListItem>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LauncherActivity._itemForPosition639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LauncherActivity.ListItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._itemForPosition639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTargetIntent640;
		protected virtual global::android.content.Intent getTargetIntent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LauncherActivity._getTargetIntent640));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._getTargetIntent640));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onQueryPackageManager641;
		protected virtual global::java.util.List onQueryPackageManager(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LauncherActivity._onQueryPackageManager641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onQueryPackageManager641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _makeListItems642;
		public virtual global::java.util.List makeListItems() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.LauncherActivity._makeListItems642));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._makeListItems642));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LauncherActivity643;
		public LauncherActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._LauncherActivity643, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.LauncherActivity.staticClass = @__class;
			global::android.app.LauncherActivity._onCreate635 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.LauncherActivity._onSetContentView636 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onSetContentView", "()V");
			global::android.app.LauncherActivity._onListItemClick637 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.LauncherActivity._intentForPosition638 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "intentForPosition", "(I)Landroid/content/Intent;");
			global::android.app.LauncherActivity._itemForPosition639 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;");
			global::android.app.LauncherActivity._getTargetIntent640 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "getTargetIntent", "()Landroid/content/Intent;");
			global::android.app.LauncherActivity._onQueryPackageManager641 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;");
			global::android.app.LauncherActivity._makeListItems642 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "makeListItems", "()Ljava/util/List;");
			global::android.app.LauncherActivity._LauncherActivity643 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "<init>", "()V");
		}
	}
}
