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
			internal static global::MonoJavaBridge.MethodId _compare4022;
			public virtual int compare(android.content.pm.ResolveInfo arg0, android.content.pm.ResolveInfo arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare4023;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator4024;
			public DisplayNameComparator(android.content.pm.PackageManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator4024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo$DisplayNameComparator"));
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4022 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare4023 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator4024 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString4025;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._toString4025)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._toString4025)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump4026;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._dump4026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._dump4026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4027;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._writeToParcel4027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._writeToParcel4027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4028;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._describeContents4028);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._describeContents4028);
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel4029;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._loadLabel4029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadLabel4029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon4030;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._loadIcon4030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadIcon4030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource4031;
		public virtual int getIconResource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._getIconResource4031);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._getIconResource4031);
		}
		internal static global::MonoJavaBridge.MethodId _ResolveInfo4032;
		public ResolveInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._ResolveInfo4032);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _activityInfo4033;
		public global::android.content.pm.ActivityInfo activityInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _activityInfo4033)) as android.content.pm.ActivityInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serviceInfo4034;
		public global::android.content.pm.ServiceInfo serviceInfo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _serviceInfo4034)) as android.content.pm.ServiceInfo;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _filter4035;
		public global::android.content.IntentFilter filter
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _filter4035)) as android.content.IntentFilter;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority4036;
		public int priority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _priority4036);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preferredOrder4037;
		public int preferredOrder
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _preferredOrder4037);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _match4038;
		public int match
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _match4038);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _specificIndex4039;
		public int specificIndex
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _specificIndex4039);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isDefault4040;
		public bool isDefault
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isDefault4040);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes4041;
		public int labelRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelRes4041);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel4042;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedLabel4042)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon4043;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon4043);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _resolvePackageName4044;
		public global::java.lang.String resolvePackageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _resolvePackageName4044)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4045;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ResolveInfo.staticClass, _CREATOR4045)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ResolveInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo"));
			global::android.content.pm.ResolveInfo._toString4025 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._dump4026 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ResolveInfo._writeToParcel4027 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ResolveInfo._describeContents4028 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ResolveInfo._loadLabel4029 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._loadIcon4030 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.ResolveInfo._getIconResource4031 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ResolveInfo._ResolveInfo4032 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ResolveInfo._activityInfo4033 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "activityInfo", "Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.ResolveInfo._serviceInfo4034 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "serviceInfo", "Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.ResolveInfo._filter4035 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "filter", "Landroid/content/IntentFilter;");
			global::android.content.pm.ResolveInfo._priority4036 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "priority", "I");
			global::android.content.pm.ResolveInfo._preferredOrder4037 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "preferredOrder", "I");
			global::android.content.pm.ResolveInfo._match4038 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "match", "I");
			global::android.content.pm.ResolveInfo._specificIndex4039 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "specificIndex", "I");
			global::android.content.pm.ResolveInfo._isDefault4040 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "isDefault", "Z");
			global::android.content.pm.ResolveInfo._labelRes4041 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "labelRes", "I");
			global::android.content.pm.ResolveInfo._nonLocalizedLabel4042 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "nonLocalizedLabel", "Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._icon4043 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "icon", "I");
			global::android.content.pm.ResolveInfo._resolvePackageName4044 = @__env.GetFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "resolvePackageName", "Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._CREATOR4045 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
