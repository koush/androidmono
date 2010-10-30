namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResolveInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResolveInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			public virtual int compare(android.content.pm.ResolveInfo arg0, android.content.pm.ResolveInfo arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I", ref global::android.content.pm.ResolveInfo.DisplayNameComparator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", ref global::android.content.pm.ResolveInfo.DisplayNameComparator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public DisplayNameComparator(android.content.pm.PackageManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.ResolveInfo.DisplayNameComparator._m2.native == global::System.IntPtr.Zero)
					global::android.content.pm.ResolveInfo.DisplayNameComparator._m2 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static DisplayNameComparator()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo$DisplayNameComparator"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ResolveInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.ResolveInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ResolveInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.ResolveInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ResolveInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ResolveInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ResolveInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.ResolveInfo._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.ResolveInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.content.pm.ResolveInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.ResolveInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.ResolveInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getIconResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ResolveInfo.staticClass, "getIconResource", "()I", ref global::android.content.pm.ResolveInfo._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ResolveInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ResolveInfo._m7.native == global::System.IntPtr.Zero)
				global::android.content.pm.ResolveInfo._m7 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._m7);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _activityInfo2113;
		public global::android.content.pm.ActivityInfo activityInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _activityInfo2113)) as android.content.pm.ActivityInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serviceInfo2114;
		public global::android.content.pm.ServiceInfo serviceInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _serviceInfo2114)) as android.content.pm.ServiceInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _filter2115;
		public global::android.content.IntentFilter filter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _filter2115)) as android.content.IntentFilter;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority2116;
		public int priority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _priority2116);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preferredOrder2117;
		public int preferredOrder
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _preferredOrder2117);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _match2118;
		public int match
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _match2118);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _specificIndex2119;
		public int specificIndex
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _specificIndex2119);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isDefault2120;
		public bool isDefault
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isDefault2120);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes2121;
		public int labelRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelRes2121);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel2122;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedLabel2122)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon2123;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon2123);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _resolvePackageName2124;
		public global::java.lang.String resolvePackageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _resolvePackageName2124)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2125;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ResolveInfo.staticClass, _CREATOR2125)) as android.os.Parcelable_Creator;
			}
		}
		static ResolveInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ResolveInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo"));
			global::android.content.pm.ResolveInfo._activityInfo2113 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "activityInfo", "Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.ResolveInfo._serviceInfo2114 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "serviceInfo", "Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.ResolveInfo._filter2115 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "filter", "Landroid/content/IntentFilter;");
			global::android.content.pm.ResolveInfo._priority2116 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "priority", "I");
			global::android.content.pm.ResolveInfo._preferredOrder2117 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "preferredOrder", "I");
			global::android.content.pm.ResolveInfo._match2118 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "match", "I");
			global::android.content.pm.ResolveInfo._specificIndex2119 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "specificIndex", "I");
			global::android.content.pm.ResolveInfo._isDefault2120 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "isDefault", "Z");
			global::android.content.pm.ResolveInfo._labelRes2121 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "labelRes", "I");
			global::android.content.pm.ResolveInfo._nonLocalizedLabel2122 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "nonLocalizedLabel", "Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._icon2123 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "icon", "I");
			global::android.content.pm.ResolveInfo._resolvePackageName2124 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "resolvePackageName", "Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._CREATOR2125 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
