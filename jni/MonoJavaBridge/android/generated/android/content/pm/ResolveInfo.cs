namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResolveInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResolveInfo()
		{
			InitJNI();
		}
		protected ResolveInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DisplayNameComparator()
			{
				InitJNI();
			}
			protected DisplayNameComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _compare4005;
			public virtual int compare(android.content.pm.ResolveInfo arg0, android.content.pm.ResolveInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare4006;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator4007;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator4007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo$DisplayNameComparator"));
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4005 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4006 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator4007 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString4008;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._toString4008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._toString4008)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump4009;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._dump4009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._dump4009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4010;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._writeToParcel4010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._writeToParcel4010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4011;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._describeContents4011);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._describeContents4011);
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel4012;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._loadLabel4012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadLabel4012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon4013;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._loadIcon4013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadIcon4013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource4014;
		public virtual int getIconResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._getIconResource4014);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._getIconResource4014);
		}
		internal static global::MonoJavaBridge.MethodId _ResolveInfo4015;
		public ResolveInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._ResolveInfo4015);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _activityInfo4016;
		public global::android.content.pm.ActivityInfo activityInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _activityInfo4016)) as android.content.pm.ActivityInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serviceInfo4017;
		public global::android.content.pm.ServiceInfo serviceInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _serviceInfo4017)) as android.content.pm.ServiceInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _filter4018;
		public global::android.content.IntentFilter filter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _filter4018)) as android.content.IntentFilter;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority4019;
		public int priority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _priority4019);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preferredOrder4020;
		public int preferredOrder
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _preferredOrder4020);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _match4021;
		public int match
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _match4021);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _specificIndex4022;
		public int specificIndex
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _specificIndex4022);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isDefault4023;
		public bool isDefault
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isDefault4023);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes4024;
		public int labelRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelRes4024);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel4025;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedLabel4025)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon4026;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon4026);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _resolvePackageName4027;
		public global::java.lang.String resolvePackageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _resolvePackageName4027)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4028;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ResolveInfo.staticClass, _CREATOR4028)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ResolveInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo"));
			global::android.content.pm.ResolveInfo._toString4008 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._dump4009 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ResolveInfo._writeToParcel4010 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ResolveInfo._describeContents4011 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ResolveInfo._loadLabel4012 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._loadIcon4013 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.ResolveInfo._getIconResource4014 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ResolveInfo._ResolveInfo4015 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ResolveInfo._activityInfo4016 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "activityInfo", "Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.ResolveInfo._serviceInfo4017 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "serviceInfo", "Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.ResolveInfo._filter4018 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "filter", "Landroid/content/IntentFilter;");
			global::android.content.pm.ResolveInfo._priority4019 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "priority", "I");
			global::android.content.pm.ResolveInfo._preferredOrder4020 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "preferredOrder", "I");
			global::android.content.pm.ResolveInfo._match4021 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "match", "I");
			global::android.content.pm.ResolveInfo._specificIndex4022 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "specificIndex", "I");
			global::android.content.pm.ResolveInfo._isDefault4023 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "isDefault", "Z");
			global::android.content.pm.ResolveInfo._labelRes4024 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "labelRes", "I");
			global::android.content.pm.ResolveInfo._nonLocalizedLabel4025 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "nonLocalizedLabel", "Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._icon4026 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "icon", "I");
			global::android.content.pm.ResolveInfo._resolvePackageName4027 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "resolvePackageName", "Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._CREATOR4028 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
