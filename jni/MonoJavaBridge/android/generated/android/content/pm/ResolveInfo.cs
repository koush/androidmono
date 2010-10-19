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
			internal static global::MonoJavaBridge.MethodId _compare2156;
			public virtual int compare(android.content.pm.ResolveInfo arg0, android.content.pm.ResolveInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare2157;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator2158;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator2158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo$DisplayNameComparator"));
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2156 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2157 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator2158 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString2159;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._toString2159)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._toString2159)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump2160;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._dump2160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._dump2160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2161;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._writeToParcel2161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._writeToParcel2161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2162;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._describeContents2162);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._describeContents2162);
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel2163;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._loadLabel2163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadLabel2163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon2164;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._loadIcon2164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadIcon2164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource2165;
		public virtual int getIconResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo._getIconResource2165);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._getIconResource2165);
		}
		internal static global::MonoJavaBridge.MethodId _ResolveInfo2166;
		public ResolveInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._ResolveInfo2166);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _activityInfo2167;
		public global::android.content.pm.ActivityInfo activityInfo
		{
			get
			{
				return default(global::android.content.pm.ActivityInfo);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serviceInfo2168;
		public global::android.content.pm.ServiceInfo serviceInfo
		{
			get
			{
				return default(global::android.content.pm.ServiceInfo);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _filter2169;
		public global::android.content.IntentFilter filter
		{
			get
			{
				return default(global::android.content.IntentFilter);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority2170;
		public int priority
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preferredOrder2171;
		public int preferredOrder
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _match2172;
		public int match
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _specificIndex2173;
		public int specificIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isDefault2174;
		public bool isDefault
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes2175;
		public int labelRes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel2176;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon2177;
		public int icon
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _resolvePackageName2178;
		public global::java.lang.String resolvePackageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2179;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ResolveInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ResolveInfo"));
			global::android.content.pm.ResolveInfo._toString2159 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._dump2160 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ResolveInfo._writeToParcel2161 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ResolveInfo._describeContents2162 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ResolveInfo._loadLabel2163 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._loadIcon2164 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.ResolveInfo._getIconResource2165 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ResolveInfo._ResolveInfo2166 = @__env.GetMethodIDNoThrow(global::android.content.pm.ResolveInfo.staticClass, "<init>", "()V");
		}
	}
}
