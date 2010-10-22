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
			internal static global::MonoJavaBridge.MethodId _createIconThumbnail1922;
			public virtual global::android.graphics.drawable.Drawable createIconThumbnail(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.IconResizer._createIconThumbnail1922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._createIconThumbnail1922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			}
			internal static global::MonoJavaBridge.MethodId _IconResizer1923;
			public IconResizer(android.app.LauncherActivity arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.IconResizer.staticClass, global::android.app.LauncherActivity.IconResizer._IconResizer1923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.IconResizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$IconResizer"));
				global::android.app.LauncherActivity.IconResizer._createIconThumbnail1922 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
				global::android.app.LauncherActivity.IconResizer._IconResizer1923 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.IconResizer.staticClass, "<init>", "(Landroid/app/LauncherActivity;)V");
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
			internal static global::MonoJavaBridge.MethodId _ListItem1924;
			public ListItem()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.ListItem.staticClass, global::android.app.LauncherActivity.ListItem._ListItem1924);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _resolveInfo1925;
			public global::android.content.pm.ResolveInfo resolveInfo
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _resolveInfo1925)) as android.content.pm.ResolveInfo;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label1926;
			public global::java.lang.CharSequence label
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label1926)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon1927;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _icon1927)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _packageName1928;
			public global::java.lang.String packageName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1928)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _className1929;
			public global::java.lang.String className
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _className1929)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _extras1930;
			public global::android.os.Bundle extras
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras1930)) as android.os.Bundle;
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.LauncherActivity.ListItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity$ListItem"));
				global::android.app.LauncherActivity.ListItem._ListItem1924 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "<init>", "()V");
				global::android.app.LauncherActivity.ListItem._resolveInfo1925 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "resolveInfo", "Landroid/content/pm/ResolveInfo;");
				global::android.app.LauncherActivity.ListItem._label1926 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "label", "Ljava/lang/CharSequence;");
				global::android.app.LauncherActivity.ListItem._icon1927 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "icon", "Landroid/graphics/drawable/Drawable;");
				global::android.app.LauncherActivity.ListItem._packageName1928 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "packageName", "Ljava/lang/String;");
				global::android.app.LauncherActivity.ListItem._className1929 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "className", "Ljava/lang/String;");
				global::android.app.LauncherActivity.ListItem._extras1930 = @__env.GetFieldIDNoThrow(global::android.app.LauncherActivity.ListItem.staticClass, "extras", "Landroid/os/Bundle;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1931;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LauncherActivity._onCreate1931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onCreate1931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSetContentView1932;
		protected virtual void onSetContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LauncherActivity._onSetContentView1932);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onSetContentView1932);
		}
		internal static global::MonoJavaBridge.MethodId _onListItemClick1933;
		protected override void onListItemClick(android.widget.ListView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.LauncherActivity._onListItemClick1933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onListItemClick1933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intentForPosition1934;
		protected virtual global::android.content.Intent intentForPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._intentForPosition1934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._intentForPosition1934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _itemForPosition1935;
		protected virtual global::android.app.LauncherActivity.ListItem itemForPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._itemForPosition1935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.LauncherActivity.ListItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._itemForPosition1935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.LauncherActivity.ListItem;
		}
		internal static global::MonoJavaBridge.MethodId _getTargetIntent1936;
		protected virtual global::android.content.Intent getTargetIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._getTargetIntent1936)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._getTargetIntent1936)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _onQueryPackageManager1937;
		protected virtual global::java.util.List onQueryPackageManager(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._onQueryPackageManager1937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._onQueryPackageManager1937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _makeListItems1938;
		public virtual global::java.util.List makeListItems() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.LauncherActivity._makeListItems1938)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._makeListItems1938)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _LauncherActivity1939;
		public LauncherActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.LauncherActivity.staticClass, global::android.app.LauncherActivity._LauncherActivity1939);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.LauncherActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/LauncherActivity"));
			global::android.app.LauncherActivity._onCreate1931 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.LauncherActivity._onSetContentView1932 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onSetContentView", "()V");
			global::android.app.LauncherActivity._onListItemClick1933 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V");
			global::android.app.LauncherActivity._intentForPosition1934 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "intentForPosition", "(I)Landroid/content/Intent;");
			global::android.app.LauncherActivity._itemForPosition1935 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;");
			global::android.app.LauncherActivity._getTargetIntent1936 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "getTargetIntent", "()Landroid/content/Intent;");
			global::android.app.LauncherActivity._onQueryPackageManager1937 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;");
			global::android.app.LauncherActivity._makeListItems1938 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "makeListItems", "()Ljava/util/List;");
			global::android.app.LauncherActivity._LauncherActivity1939 = @__env.GetMethodIDNoThrow(global::android.app.LauncherActivity.staticClass, "<init>", "()V");
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
