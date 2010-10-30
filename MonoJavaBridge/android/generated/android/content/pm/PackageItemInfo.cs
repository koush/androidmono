namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageItemInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageItemInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DisplayNameComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual int compare(android.content.pm.PackageItemInfo arg0, android.content.pm.PackageItemInfo arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I", ref global::android.content.pm.PackageItemInfo.DisplayNameComparator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", ref global::android.content.pm.PackageItemInfo.DisplayNameComparator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public DisplayNameComparator(android.content.pm.PackageManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.PackageItemInfo.DisplayNameComparator._m2.native == global::System.IntPtr.Zero)
					global::android.content.pm.PackageItemInfo.DisplayNameComparator._m2 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static DisplayNameComparator()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageItemInfo$DisplayNameComparator"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageItemInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PackageItemInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PackageItemInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.PackageItemInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageItemInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageItemInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.content.res.XmlResourceParser loadXmlMetaData(android.content.pm.PackageManager arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.pm.PackageItemInfo.staticClass, "loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlResourceParser;", ref global::android.content.pm.PackageItemInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.XmlResourceParser;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void dumpFront(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageItemInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.PackageItemInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpFront(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpFront((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void dumpBack(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageItemInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.PackageItemInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpBack(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpBack((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PackageItemInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageItemInfo._m6.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageItemInfo._m6 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._m6);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PackageItemInfo(android.content.pm.PackageItemInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageItemInfo._m7.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageItemInfo._m7 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/content/pm/PackageItemInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected PackageItemInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageItemInfo._m8.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageItemInfo._m8 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name2030;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name2030)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName2031;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName2031)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes2032;
		public int labelRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelRes2032);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel2033;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedLabel2033)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon2034;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon2034);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _metaData2035;
		public global::android.os.Bundle metaData
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _metaData2035)) as android.os.Bundle;
			}
			set
			{
			}
		}
		static PackageItemInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageItemInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageItemInfo"));
			global::android.content.pm.PackageItemInfo._name2030 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "name", "Ljava/lang/String;");
			global::android.content.pm.PackageItemInfo._packageName2031 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageItemInfo._labelRes2032 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "labelRes", "I");
			global::android.content.pm.PackageItemInfo._nonLocalizedLabel2033 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "nonLocalizedLabel", "Ljava/lang/CharSequence;");
			global::android.content.pm.PackageItemInfo._icon2034 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "icon", "I");
			global::android.content.pm.PackageItemInfo._metaData2035 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "metaData", "Landroid/os/Bundle;");
		}
		internal static void InitJNI()
		{
		}
	}
}
