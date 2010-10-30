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
			internal static global::MonoJavaBridge.MethodId _createIconThumbnail1926;
			public virtual global::android.graphics.drawable.Drawable createIconThumbnail(android.graphics.drawable.Drawable arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.LauncherActivity.IconResizer._createIconThumbnail1926.native == global::System.IntPtr.Zero)
					global::android.app.LauncherActivity.IconResizer._createIconThumbnail1926 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._createIconThumbnail1926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
			}
			internal static global::MonoJavaBridge.MethodId _IconResizer1927;
			public IconResizer(android.app.LauncherActivity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.LauncherActivity.IconResizer._IconResizer1927.native == global::System.IntPtr.Zero)
					global::android.app.LauncherActivity.IconResizer._IconResizer1927 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "<init>", "(Landroid/app/LauncherActivity;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._IconResizer1927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _ListItem1928;
			public ListItem() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.LauncherActivity.ListItem._ListItem1928.native == global::System.IntPtr.Zero)
					global::android.app.LauncherActivity.ListItem._ListItem1928 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.ListItem.staticClass, global::android.app.LauncherActivity.ListItem._ListItem1928);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _resolveInfo1929;
			public global::android.content.pm.ResolveInfo resolveInfo
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _resolveInfo1929)) as android.content.pm.ResolveInfo;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label1930;
			public global::java.lang.CharSequence label
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label1930)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon1931;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _icon1931)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _packageName1932;
			public global::java.lang.String packageName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1932)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _className1933;
			public global::java.lang.String className
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _className1933)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _extras1934;
			public global::android.os.Bundle extras
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras1934)) as android.os.Bundle;
				}
				set
				{
				}
			}
			static ListItem()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.ListItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$ListItem"));
				global::android.app.LauncherActivity.ListItem._resolveInfo1929 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "resolveInfo", "Landroid/content/pm/ResolveInfo;");
				global::android.app.LauncherActivity.ListItem._label1930 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "label", "Ljava/lang/CharSequence;");
				global::android.app.LauncherActivity.ListItem._icon1931 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "icon", "Landroid/graphics/drawable/Drawable;");
				global::android.app.LauncherActivity.ListItem._packageName1932 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "packageName", "Ljava/lang/String;");
				global::android.app.LauncherActivity.ListItem._className1933 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "className", "Ljava/lang/String;");
				global::android.app.LauncherActivity.ListItem._extras1934 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "extras", "Landroid/os/Bundle;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1935;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._onCreate1935.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._onCreate1935 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onCreate1935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSetContentView1936;
		protected virtual void onSetContentView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._onSetContentView1936.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._onSetContentView1936 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onSetContentView", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onSetContentView1936);
		}
		internal static global::MonoJavaBridge.MethodId _onListItemClick1937;
		protected override void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._onListItemClick1937.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._onListItemClick1937 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onListItemClick1937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intentForPosition1938;
		protected virtual global::android.content.Intent intentForPosition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._intentForPosition1938.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._intentForPosition1938 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "intentForPosition", "(I)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._intentForPosition1938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _itemForPosition1939;
		protected virtual global::android.app.LauncherActivity.ListItem itemForPosition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._itemForPosition1939.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._itemForPosition1939 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._itemForPosition1939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.LauncherActivity.ListItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetIntent1940;
		protected virtual global::android.content.Intent getTargetIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._getTargetIntent1940.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._getTargetIntent1940 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "getTargetIntent", "()Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._getTargetIntent1940) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _onQueryPackageManager1941;
		protected virtual global::java.util.List onQueryPackageManager(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._onQueryPackageManager1941.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._onQueryPackageManager1941 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onQueryPackageManager1941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _makeListItems1942;
		public virtual global::java.util.List makeListItems()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._makeListItems1942.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._makeListItems1942 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "makeListItems", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._makeListItems1942) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _LauncherActivity1943;
		public LauncherActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.LauncherActivity._LauncherActivity1943.native == global::System.IntPtr.Zero)
				global::android.app.LauncherActivity._LauncherActivity1943 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._LauncherActivity1943);
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
