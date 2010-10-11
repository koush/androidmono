namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.LauncherActivity_))]
	public abstract partial class LauncherActivity : android.app.ListActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LauncherActivity()
		{
			InitJNI();
		}
		protected LauncherActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class IconResizer : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IconResizer()
			{
				InitJNI();
			}
			protected IconResizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createIconThumbnail636;
			public virtual global::android.graphics.drawable.Drawable createIconThumbnail(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.IconResizer._createIconThumbnail636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._createIconThumbnail636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			}
			internal static global::MonoJavaBridge.MethodId _IconResizer637;
			public IconResizer(android.app.LauncherActivity arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._IconResizer637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.IconResizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$IconResizer"));
				global::android.app.LauncherActivity.IconResizer._createIconThumbnail636 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
				global::android.app.LauncherActivity.IconResizer._IconResizer637 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "<init>", "(Landroid/app/LauncherActivity;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ListItem : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ListItem()
			{
				InitJNI();
			}
			protected ListItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ListItem638;
			public ListItem()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.ListItem.staticClass, global::android.app.LauncherActivity.ListItem._ListItem638);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _resolveInfo639;
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
			internal static global::MonoJavaBridge.FieldId _label640;
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
			internal static global::MonoJavaBridge.FieldId _icon641;
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
			internal static global::MonoJavaBridge.FieldId _packageName642;
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
			internal static global::MonoJavaBridge.FieldId _className643;
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
			internal static global::MonoJavaBridge.FieldId _extras644;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.ListItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$ListItem"));
				global::android.app.LauncherActivity.ListItem._ListItem638 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onCreate645;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LauncherActivity._onCreate645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onCreate645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSetContentView646;
		protected virtual void onSetContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LauncherActivity._onSetContentView646);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onSetContentView646);
		}
		internal static global::MonoJavaBridge.MethodId _onListItemClick647;
		protected override void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LauncherActivity._onListItemClick647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onListItemClick647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intentForPosition648;
		protected virtual global::android.content.Intent intentForPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._intentForPosition648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._intentForPosition648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _itemForPosition649;
		protected virtual global::android.app.LauncherActivity.ListItem itemForPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._itemForPosition649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.LauncherActivity.ListItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._itemForPosition649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.LauncherActivity.ListItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetIntent650;
		protected virtual global::android.content.Intent getTargetIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._getTargetIntent650)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._getTargetIntent650)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _onQueryPackageManager651;
		protected virtual global::java.util.List onQueryPackageManager(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._onQueryPackageManager651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onQueryPackageManager651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _makeListItems652;
		public virtual global::java.util.List makeListItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._makeListItems652)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._makeListItems652)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _LauncherActivity653;
		public LauncherActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._LauncherActivity653);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LauncherActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity"));
			global::android.app.LauncherActivity._onCreate645 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.LauncherActivity._onSetContentView646 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onSetContentView", "()V");
			global::android.app.LauncherActivity._onListItemClick647 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.LauncherActivity._intentForPosition648 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "intentForPosition", "(I)Landroid/content/Intent;");
			global::android.app.LauncherActivity._itemForPosition649 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;");
			global::android.app.LauncherActivity._getTargetIntent650 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "getTargetIntent", "()Landroid/content/Intent;");
			global::android.app.LauncherActivity._onQueryPackageManager651 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;");
			global::android.app.LauncherActivity._makeListItems652 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "makeListItems", "()Ljava/util/List;");
			global::android.app.LauncherActivity._LauncherActivity653 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.LauncherActivity))]
	public sealed partial class LauncherActivity_ : android.app.LauncherActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LauncherActivity_()
		{
			InitJNI();
		}
		internal LauncherActivity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LauncherActivity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity"));
		}
	}
}
