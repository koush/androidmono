namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.LauncherActivity_))]
	public abstract partial class LauncherActivity : android.app.ListActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LauncherActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class IconResizer : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected IconResizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::android.graphics.drawable.Drawable createIconThumbnail(android.graphics.drawable.Drawable arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.IconResizer.staticClass, "createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", ref global::android.app.LauncherActivity.IconResizer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public IconResizer(android.app.LauncherActivity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.LauncherActivity.IconResizer._m1.native == global::System.IntPtr.Zero)
					global::android.app.LauncherActivity.IconResizer._m1 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "<init>", "(Landroid/app/LauncherActivity;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static IconResizer()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.IconResizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$IconResizer"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ListItem : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ListItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ListItem() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.LauncherActivity.ListItem._m0.native == global::System.IntPtr.Zero)
					global::android.app.LauncherActivity.ListItem._m0 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.ListItem.staticClass, global::android.app.LauncherActivity.ListItem._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _resolveInfo1354;
			public global::android.content.pm.ResolveInfo resolveInfo
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _resolveInfo1354)) as android.content.pm.ResolveInfo;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label1355;
			public global::java.lang.CharSequence label
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label1355)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon1356;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _icon1356)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _packageName1357;
			public global::java.lang.String packageName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1357)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _className1358;
			public global::java.lang.String className
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _className1358)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _extras1359;
			public global::android.os.Bundle extras
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras1359)) as android.os.Bundle;
				}
				set
				{
				}
			}
			static ListItem()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.ListItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$ListItem"));
				global::android.app.LauncherActivity.ListItem._resolveInfo1354 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "resolveInfo", "Landroid/content/pm/ResolveInfo;");
				global::android.app.LauncherActivity.ListItem._label1355 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "label", "Ljava/lang/CharSequence;");
				global::android.app.LauncherActivity.ListItem._icon1356 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "icon", "Landroid/graphics/drawable/Drawable;");
				global::android.app.LauncherActivity.ListItem._packageName1357 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "packageName", "Ljava/lang/String;");
				global::android.app.LauncherActivity.ListItem._className1358 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "className", "Ljava/lang/String;");
				global::android.app.LauncherActivity.ListItem._extras1359 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "extras", "Landroid/os/Bundle;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LauncherActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.LauncherActivity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual void onSetContentView()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LauncherActivity.staticClass, "onSetContentView", "()V", ref global::android.app.LauncherActivity._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LauncherActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", ref global::android.app.LauncherActivity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual global::android.content.Intent intentForPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.staticClass, "intentForPosition", "(I)Landroid/content/Intent;", ref global::android.app.LauncherActivity._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual global::android.app.LauncherActivity.ListItem itemForPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.staticClass, "itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;", ref global::android.app.LauncherActivity._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.LauncherActivity.ListItem;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual global::android.content.Intent getTargetIntent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.staticClass, "getTargetIntent", "()Landroid/content/Intent;", ref global::android.app.LauncherActivity._m5) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual global::java.util.List onQueryPackageManager(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.LauncherActivity.staticClass, "onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;", ref global::android.app.LauncherActivity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.List makeListItems()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.LauncherActivity.staticClass, "makeListItems", "()Ljava/util/List;", ref global::android.app.LauncherActivity._m7) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public LauncherActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._m8.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._m8 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._m8);
			Init(@__env, handle);
		}
		static LauncherActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LauncherActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.LauncherActivity))]
	internal sealed partial class LauncherActivity_ : android.app.LauncherActivity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LauncherActivity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static LauncherActivity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LauncherActivity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
