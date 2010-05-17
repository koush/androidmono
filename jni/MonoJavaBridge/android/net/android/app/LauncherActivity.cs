namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class LauncherActivity : android.app.ListActivity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LauncherActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.LauncherActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.LauncherActivity.IconResizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _createIconThumbnail608; 
			public virtual android.graphics.drawable.Drawable createIconThumbnail(android.graphics.drawable.Drawable arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.LauncherActivity.IconResizer)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _createIconThumbnail608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LauncherActivity.IconResizer.staticClass, _createIconThumbnail608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _IconResizer609; 
			public IconResizer(android.app.LauncherActivity arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.LauncherActivity.IconResizer.staticClass, _IconResizer609, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.LauncherActivity.IconResizer.staticClass = @__class; 
				global::android.app.LauncherActivity.IconResizer._createIconThumbnail608 = @__env.GetMethodID(global::android.app.LauncherActivity.IconResizer.staticClass, "createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;"); 
				global::android.app.LauncherActivity.IconResizer._IconResizer609 = @__env.GetMethodID(global::android.app.LauncherActivity.IconResizer.staticClass, "<init>", "(Landroid/app/LauncherActivity;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class ListItem : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ListItem() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.LauncherActivity.ListItem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _ListItem610; 
			public ListItem()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.LauncherActivity.ListItem.staticClass, _ListItem610, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _resolveInfo611; 
			public android.content.pm.ResolveInfo resolveInfo
			{ 
				get 
				{ 
					return default(android.content.pm.ResolveInfo); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _label612; 
			public java.lang.CharSequence label
			{ 
				get 
				{ 
					return default(java.lang.CharSequence); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _icon613; 
			public android.graphics.drawable.Drawable icon
			{ 
				get 
				{ 
					return default(android.graphics.drawable.Drawable); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _packageName614; 
			public java.lang.String packageName
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _className615; 
			public java.lang.String className
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _extras616; 
			public android.os.Bundle extras
			{ 
				get 
				{ 
					return default(android.os.Bundle); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.LauncherActivity.ListItem.staticClass = @__class; 
				global::android.app.LauncherActivity.ListItem._ListItem610 = @__env.GetMethodID(global::android.app.LauncherActivity.ListItem.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate617; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				@__env.CallVoidMethod(this, _onCreate617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LauncherActivity.staticClass, _onCreate617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSetContentView618; 
		protected virtual void onSetContentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				@__env.CallVoidMethod(this, _onSetContentView618); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LauncherActivity.staticClass, _onSetContentView618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onListItemClick619; 
		protected override void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				@__env.CallVoidMethod(this, _onListItemClick619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.LauncherActivity.staticClass, _onListItemClick619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intentForPosition620; 
		protected virtual android.content.Intent intentForPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _intentForPosition620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LauncherActivity.staticClass, _intentForPosition620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _itemForPosition621; 
		protected virtual android.app.LauncherActivity.ListItem itemForPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LauncherActivity.ListItem>(@__env, @__env.CallObjectMethodPtr(this, _itemForPosition621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.LauncherActivity.ListItem>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LauncherActivity.staticClass, _itemForPosition621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTargetIntent622; 
		protected virtual android.content.Intent getTargetIntent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _getTargetIntent622)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LauncherActivity.staticClass, _getTargetIntent622)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onQueryPackageManager623; 
		protected virtual java.util.List onQueryPackageManager(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _onQueryPackageManager623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LauncherActivity.staticClass, _onQueryPackageManager623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeListItems624; 
		public virtual java.util.List makeListItems() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.LauncherActivity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _makeListItems624)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.LauncherActivity.staticClass, _makeListItems624)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LauncherActivity625; 
		public LauncherActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.LauncherActivity.staticClass, _LauncherActivity625, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.LauncherActivity.staticClass = @__class; 
			global::android.app.LauncherActivity._onCreate617 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.LauncherActivity._onSetContentView618 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onSetContentView", "()V"); 
			global::android.app.LauncherActivity._onListItemClick619 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V"); 
			global::android.app.LauncherActivity._intentForPosition620 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "intentForPosition", "(I)Landroid/content/Intent;"); 
			global::android.app.LauncherActivity._itemForPosition621 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;"); 
			global::android.app.LauncherActivity._getTargetIntent622 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "getTargetIntent", "()Landroid/content/Intent;"); 
			global::android.app.LauncherActivity._onQueryPackageManager623 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;"); 
			global::android.app.LauncherActivity._makeListItems624 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "makeListItems", "()Ljava/util/List;"); 
			global::android.app.LauncherActivity._LauncherActivity625 = @__env.GetMethodID(global::android.app.LauncherActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
