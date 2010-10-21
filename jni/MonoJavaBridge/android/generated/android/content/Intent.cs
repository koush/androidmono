namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Intent : java.lang.Object, android.os.Parcelable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Intent()
		{
			InitJNI();
		}
		protected Intent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class FilterComparison : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterComparison()
			{
				InitJNI();
			}
			internal FilterComparison(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals3086;
			public sealed override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent.FilterComparison._equals3086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._equals3086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _hashCode3087;
			public sealed override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent.FilterComparison._hashCode3087);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._hashCode3087);
			}
			public new global::android.content.Intent Intent
			{
				get
				{
					return getIntent();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getIntent3088;
			public global::android.content.Intent getIntent() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent.FilterComparison._getIntent3088)) as android.content.Intent;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._getIntent3088)) as android.content.Intent;
			}
			internal static global::MonoJavaBridge.MethodId _FilterComparison3089;
			public FilterComparison(android.content.Intent arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._FilterComparison3089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.FilterComparison.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$FilterComparison"));
				global::android.content.Intent.FilterComparison._equals3086 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.content.Intent.FilterComparison._hashCode3087 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "hashCode", "()I");
				global::android.content.Intent.FilterComparison._getIntent3088 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "getIntent", "()Landroid/content/Intent;");
				global::android.content.Intent.FilterComparison._FilterComparison3089 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "<init>", "(Landroid/content/Intent;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ShortcutIconResource : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ShortcutIconResource()
			{
				InitJNI();
			}
			protected ShortcutIconResource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString3090;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource._toString3090)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._toString3090)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel3091;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource._writeToParcel3091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._writeToParcel3091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents3092;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource._describeContents3092);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._describeContents3092);
			}
			internal static global::MonoJavaBridge.MethodId _fromContext3093;
			public static global::android.content.Intent.ShortcutIconResource fromContext(android.content.Context arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._fromContext3093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent.ShortcutIconResource;
			}
			internal static global::MonoJavaBridge.MethodId _ShortcutIconResource3094;
			public ShortcutIconResource()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._ShortcutIconResource3094);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _packageName3095;
			public global::java.lang.String packageName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _packageName3095)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _resourceName3096;
			public global::java.lang.String resourceName
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _resourceName3096)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR3097;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.Intent.ShortcutIconResource.staticClass, _CREATOR3097)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.ShortcutIconResource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$ShortcutIconResource"));
				global::android.content.Intent.ShortcutIconResource._toString3090 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "toString", "()Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._writeToParcel3091 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.content.Intent.ShortcutIconResource._describeContents3092 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "describeContents", "()I");
				global::android.content.Intent.ShortcutIconResource._fromContext3093 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;");
				global::android.content.Intent.ShortcutIconResource._ShortcutIconResource3094 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "<init>", "()V");
				global::android.content.Intent.ShortcutIconResource._packageName3095 = @__env.GetFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "packageName", "Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._resourceName3096 = @__env.GetFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "resourceName", "Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._CREATOR3097 = @__env.GetStaticFieldIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString3098;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._toString3098)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._toString3098)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone3099;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._clone3099)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._clone3099)) as java.lang.Object;
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage3100;
		public virtual global::java.lang.String getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getPackage3100)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getPackage3100)) as java.lang.String;
		}
		public new global::java.lang.String Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType3101;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getType3101)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getType3101)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI3102;
		public virtual global::java.lang.String toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._toURI3102)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._toURI3102)) as java.lang.String;
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme3103;
		public virtual global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getScheme3103)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getScheme3103)) as java.lang.String;
		}
		public new global::android.net.Uri Data
		{
			get
			{
				return getData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getData3104;
		public virtual global::android.net.Uri getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getData3104)) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getData3104)) as android.net.Uri;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent3105;
		public virtual global::android.content.ComponentName getComponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getComponent3105)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getComponent3105)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _setClassName3106;
		public virtual global::android.content.Intent setClassName(android.content.Context arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setClassName3106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setClassName3106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setClassName3107;
		public virtual global::android.content.Intent setClassName(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setClassName3107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setClassName3107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3108;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._writeToParcel3108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._writeToParcel3108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3109;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._describeContents3109);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._describeContents3109);
		}
		internal static global::MonoJavaBridge.MethodId _createChooser3110;
		public static global::android.content.Intent createChooser(android.content.Intent arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._createChooser3110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _cloneFilter3111;
		public virtual global::android.content.Intent cloneFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._cloneFilter3111)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._cloneFilter3111)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent3112;
		public static global::android.content.Intent getIntent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._getIntent3112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _parseUri3113;
		public static global::android.content.Intent parseUri(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._parseUri3113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getIntentOld3114;
		public static global::android.content.Intent getIntentOld(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._getIntentOld3114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		public new global::java.lang.String Action
		{
			get
			{
				return getAction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAction3115;
		public virtual global::java.lang.String getAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getAction3115)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getAction3115)) as java.lang.String;
		}
		public new global::java.lang.String DataString
		{
			get
			{
				return getDataString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataString3116;
		public virtual global::java.lang.String getDataString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getDataString3116)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getDataString3116)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveType3117;
		public virtual global::java.lang.String resolveType(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveType3117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveType3117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveType3118;
		public virtual global::java.lang.String resolveType(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveType3118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveType3118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveTypeIfNeeded3119;
		public virtual global::java.lang.String resolveTypeIfNeeded(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveTypeIfNeeded3119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveTypeIfNeeded3119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasCategory3120;
		public virtual bool hasCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._hasCategory3120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._hasCategory3120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Set Categories
		{
			get
			{
				return getCategories();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCategories3121;
		public virtual global::java.util.Set getCategories() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCategories3121)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCategories3121)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setExtrasClassLoader3122;
		public virtual void setExtrasClassLoader(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._setExtrasClassLoader3122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setExtrasClassLoader3122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasExtra3123;
		public virtual bool hasExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._hasExtra3123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._hasExtra3123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors3124;
		public virtual bool hasFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._hasFileDescriptors3124);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._hasFileDescriptors3124);
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanExtra3125;
		public virtual bool getBooleanExtra(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._getBooleanExtra3125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getBooleanExtra3125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteExtra3126;
		public virtual byte getByteExtra(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.content.Intent._getByteExtra3126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getByteExtra3126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShortExtra3127;
		public virtual short getShortExtra(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.content.Intent._getShortExtra3127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getShortExtra3127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCharExtra3128;
		public virtual char getCharExtra(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.content.Intent._getCharExtra3128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharExtra3128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIntExtra3129;
		public virtual int getIntExtra(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._getIntExtra3129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getIntExtra3129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLongExtra3130;
		public virtual long getLongExtra(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.Intent._getLongExtra3130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getLongExtra3130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloatExtra3131;
		public virtual float getFloatExtra(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.Intent._getFloatExtra3131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getFloatExtra3131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleExtra3132;
		public virtual double getDoubleExtra(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.content.Intent._getDoubleExtra3132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getDoubleExtra3132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getStringExtra3133;
		public virtual global::java.lang.String getStringExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getStringExtra3133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getStringExtra3133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceExtra3134;
		public virtual global::java.lang.CharSequence getCharSequenceExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharSequenceExtra3134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharSequenceExtra3134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableExtra3135;
		public virtual global::android.os.Parcelable getParcelableExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getParcelableExtra3135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getParcelableExtra3135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayExtra3136;
		public virtual global::android.os.Parcelable[] getParcelableArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getParcelableArrayExtra3136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getParcelableArrayExtra3136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayListExtra3137;
		public virtual global::java.util.ArrayList getParcelableArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getParcelableArrayListExtra3137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getParcelableArrayListExtra3137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getSerializableExtra3138;
		public virtual global::java.io.Serializable getSerializableExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getSerializableExtra3138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getSerializableExtra3138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerArrayListExtra3139;
		public virtual global::java.util.ArrayList getIntegerArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getIntegerArrayListExtra3139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getIntegerArrayListExtra3139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayListExtra3140;
		public virtual global::java.util.ArrayList getStringArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getStringArrayListExtra3140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getStringArrayListExtra3140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayListExtra3141;
		public virtual global::java.util.ArrayList getCharSequenceArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharSequenceArrayListExtra3141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharSequenceArrayListExtra3141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanArrayExtra3142;
		public virtual bool[] getBooleanArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getBooleanArrayExtra3142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getBooleanArrayExtra3142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getByteArrayExtra3143;
		public virtual byte[] getByteArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getByteArrayExtra3143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getByteArrayExtra3143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getShortArrayExtra3144;
		public virtual short[] getShortArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getShortArrayExtra3144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getShortArrayExtra3144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharArrayExtra3145;
		public virtual char[] getCharArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharArrayExtra3145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharArrayExtra3145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArrayExtra3146;
		public virtual int[] getIntArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getIntArrayExtra3146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getIntArrayExtra3146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getLongArrayExtra3147;
		public virtual long[] getLongArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getLongArrayExtra3147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getLongArrayExtra3147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _getFloatArrayExtra3148;
		public virtual float[] getFloatArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getFloatArrayExtra3148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getFloatArrayExtra3148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleArrayExtra3149;
		public virtual double[] getDoubleArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getDoubleArrayExtra3149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getDoubleArrayExtra3149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayExtra3150;
		public virtual global::java.lang.String[] getStringArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getStringArrayExtra3150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getStringArrayExtra3150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayExtra3151;
		public virtual global::java.lang.CharSequence[] getCharSequenceArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharSequenceArrayExtra3151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharSequenceArrayExtra3151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getBundleExtra3152;
		public virtual global::android.os.Bundle getBundleExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getBundleExtra3152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getBundleExtra3152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras3153;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getExtras3153)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getExtras3153)) as android.os.Bundle;
		}
		public new int Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags3154;
		public virtual int getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._getFlags3154);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getFlags3154);
		}
		public new global::android.graphics.Rect SourceBounds
		{
			get
			{
				return getSourceBounds();
			}
			set
			{
				setSourceBounds(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourceBounds3155;
		public virtual global::android.graphics.Rect getSourceBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getSourceBounds3155)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getSourceBounds3155)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity3156;
		public virtual global::android.content.ComponentName resolveActivity(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveActivity3156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveActivity3156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivityInfo3157;
		public virtual global::android.content.pm.ActivityInfo resolveActivityInfo(android.content.pm.PackageManager arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveActivityInfo3157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveActivityInfo3157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _setAction3158;
		public virtual global::android.content.Intent setAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setAction3158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setAction3158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setData3159;
		public virtual global::android.content.Intent setData(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setData3159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setData3159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setType3160;
		public virtual global::android.content.Intent setType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setType3160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setType3160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setDataAndType3161;
		public virtual global::android.content.Intent setDataAndType(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setDataAndType3161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setDataAndType3161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _addCategory3162;
		public virtual global::android.content.Intent addCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._addCategory3162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._addCategory3162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _removeCategory3163;
		public virtual void removeCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._removeCategory3163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._removeCategory3163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3164;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3165;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3166;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3167;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3168;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3169;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3170;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3171;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3172;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3173;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3174;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		public android.content.Intent putExtra(java.lang.String arg0, string arg1)
		{
			return putExtra(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3175;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3176;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3177;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.io.Serializable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3178;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3179;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3180;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3181;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3182;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3183;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3184;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3185;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3186;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra3187;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra3187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra3187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArrayListExtra3188;
		public virtual global::android.content.Intent putParcelableArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putParcelableArrayListExtra3188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putParcelableArrayListExtra3188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putIntegerArrayListExtra3189;
		public virtual global::android.content.Intent putIntegerArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putIntegerArrayListExtra3189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putIntegerArrayListExtra3189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putStringArrayListExtra3190;
		public virtual global::android.content.Intent putStringArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putStringArrayListExtra3190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putStringArrayListExtra3190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArrayListExtra3191;
		public virtual global::android.content.Intent putCharSequenceArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putCharSequenceArrayListExtra3191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putCharSequenceArrayListExtra3191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtras3192;
		public virtual global::android.content.Intent putExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtras3192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtras3192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtras3193;
		public virtual global::android.content.Intent putExtras(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtras3193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtras3193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _replaceExtras3194;
		public virtual global::android.content.Intent replaceExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._replaceExtras3194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._replaceExtras3194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _replaceExtras3195;
		public virtual global::android.content.Intent replaceExtras(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._replaceExtras3195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._replaceExtras3195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _removeExtra3196;
		public virtual void removeExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._removeExtra3196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._removeExtra3196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags3197;
		public virtual global::android.content.Intent setFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setFlags3197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setFlags3197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _addFlags3198;
		public virtual global::android.content.Intent addFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._addFlags3198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._addFlags3198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setPackage3199;
		public virtual global::android.content.Intent setPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setPackage3199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setPackage3199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setComponent3200;
		public virtual global::android.content.Intent setComponent(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setComponent3200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setComponent3200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setClass3201;
		public virtual global::android.content.Intent setClass(android.content.Context arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setClass3201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setClass3201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setSourceBounds3202;
		public virtual void setSourceBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._setSourceBounds3202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setSourceBounds3202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fillIn3203;
		public virtual int fillIn(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._fillIn3203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._fillIn3203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _filterEquals3204;
		public virtual bool filterEquals(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._filterEquals3204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._filterEquals3204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _filterHashCode3205;
		public virtual int filterHashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._filterHashCode3205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._filterHashCode3205);
		}
		internal static global::MonoJavaBridge.MethodId _toUri3206;
		public virtual global::java.lang.String toUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._toUri3206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._toUri3206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel3207;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._readFromParcel3207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._readFromParcel3207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseIntent3208;
		public static global::android.content.Intent parseIntent(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._parseIntent3208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _Intent3209;
		public Intent()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3209);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3210;
		public Intent(android.content.Intent arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3211;
		public Intent(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3212;
		public Intent(java.lang.String arg0, android.net.Uri arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3213;
		public Intent(android.content.Context arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent3214;
		public Intent(java.lang.String arg0, android.net.Uri arg1, android.content.Context arg2, java.lang.Class arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent3214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		public static global::java.lang.String ACTION_MAIN
		{
			get
			{
				return "android.intent.action.MAIN";
			}
		}
		public static global::java.lang.String ACTION_VIEW
		{
			get
			{
				return "android.intent.action.VIEW";
			}
		}
		public static global::java.lang.String ACTION_DEFAULT
		{
			get
			{
				return "android.intent.action.VIEW";
			}
		}
		public static global::java.lang.String ACTION_ATTACH_DATA
		{
			get
			{
				return "android.intent.action.ATTACH_DATA";
			}
		}
		public static global::java.lang.String ACTION_EDIT
		{
			get
			{
				return "android.intent.action.EDIT";
			}
		}
		public static global::java.lang.String ACTION_INSERT_OR_EDIT
		{
			get
			{
				return "android.intent.action.INSERT_OR_EDIT";
			}
		}
		public static global::java.lang.String ACTION_PICK
		{
			get
			{
				return "android.intent.action.PICK";
			}
		}
		public static global::java.lang.String ACTION_CREATE_SHORTCUT
		{
			get
			{
				return "android.intent.action.CREATE_SHORTCUT";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_INTENT
		{
			get
			{
				return "android.intent.extra.shortcut.INTENT";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_NAME
		{
			get
			{
				return "android.intent.extra.shortcut.NAME";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_ICON
		{
			get
			{
				return "android.intent.extra.shortcut.ICON";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_ICON_RESOURCE
		{
			get
			{
				return "android.intent.extra.shortcut.ICON_RESOURCE";
			}
		}
		public static global::java.lang.String ACTION_CHOOSER
		{
			get
			{
				return "android.intent.action.CHOOSER";
			}
		}
		public static global::java.lang.String ACTION_GET_CONTENT
		{
			get
			{
				return "android.intent.action.GET_CONTENT";
			}
		}
		public static global::java.lang.String ACTION_DIAL
		{
			get
			{
				return "android.intent.action.DIAL";
			}
		}
		public static global::java.lang.String ACTION_CALL
		{
			get
			{
				return "android.intent.action.CALL";
			}
		}
		public static global::java.lang.String ACTION_SENDTO
		{
			get
			{
				return "android.intent.action.SENDTO";
			}
		}
		public static global::java.lang.String ACTION_SEND
		{
			get
			{
				return "android.intent.action.SEND";
			}
		}
		public static global::java.lang.String ACTION_SEND_MULTIPLE
		{
			get
			{
				return "android.intent.action.SEND_MULTIPLE";
			}
		}
		public static global::java.lang.String ACTION_ANSWER
		{
			get
			{
				return "android.intent.action.ANSWER";
			}
		}
		public static global::java.lang.String ACTION_INSERT
		{
			get
			{
				return "android.intent.action.INSERT";
			}
		}
		public static global::java.lang.String ACTION_DELETE
		{
			get
			{
				return "android.intent.action.DELETE";
			}
		}
		public static global::java.lang.String ACTION_RUN
		{
			get
			{
				return "android.intent.action.RUN";
			}
		}
		public static global::java.lang.String ACTION_SYNC
		{
			get
			{
				return "android.intent.action.SYNC";
			}
		}
		public static global::java.lang.String ACTION_PICK_ACTIVITY
		{
			get
			{
				return "android.intent.action.PICK_ACTIVITY";
			}
		}
		public static global::java.lang.String ACTION_SEARCH
		{
			get
			{
				return "android.intent.action.SEARCH";
			}
		}
		public static global::java.lang.String ACTION_SYSTEM_TUTORIAL
		{
			get
			{
				return "android.intent.action.SYSTEM_TUTORIAL";
			}
		}
		public static global::java.lang.String ACTION_WEB_SEARCH
		{
			get
			{
				return "android.intent.action.WEB_SEARCH";
			}
		}
		public static global::java.lang.String ACTION_ALL_APPS
		{
			get
			{
				return "android.intent.action.ALL_APPS";
			}
		}
		public static global::java.lang.String ACTION_SET_WALLPAPER
		{
			get
			{
				return "android.intent.action.SET_WALLPAPER";
			}
		}
		public static global::java.lang.String ACTION_BUG_REPORT
		{
			get
			{
				return "android.intent.action.BUG_REPORT";
			}
		}
		public static global::java.lang.String ACTION_FACTORY_TEST
		{
			get
			{
				return "android.intent.action.FACTORY_TEST";
			}
		}
		public static global::java.lang.String ACTION_CALL_BUTTON
		{
			get
			{
				return "android.intent.action.CALL_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_VOICE_COMMAND
		{
			get
			{
				return "android.intent.action.VOICE_COMMAND";
			}
		}
		public static global::java.lang.String ACTION_SEARCH_LONG_PRESS
		{
			get
			{
				return "android.intent.action.SEARCH_LONG_PRESS";
			}
		}
		public static global::java.lang.String ACTION_POWER_USAGE_SUMMARY
		{
			get
			{
				return "android.intent.action.POWER_USAGE_SUMMARY";
			}
		}
		public static global::java.lang.String ACTION_SCREEN_OFF
		{
			get
			{
				return "android.intent.action.SCREEN_OFF";
			}
		}
		public static global::java.lang.String ACTION_SCREEN_ON
		{
			get
			{
				return "android.intent.action.SCREEN_ON";
			}
		}
		public static global::java.lang.String ACTION_USER_PRESENT
		{
			get
			{
				return "android.intent.action.USER_PRESENT";
			}
		}
		public static global::java.lang.String ACTION_TIME_TICK
		{
			get
			{
				return "android.intent.action.TIME_TICK";
			}
		}
		public static global::java.lang.String ACTION_TIME_CHANGED
		{
			get
			{
				return "android.intent.action.TIME_SET";
			}
		}
		public static global::java.lang.String ACTION_DATE_CHANGED
		{
			get
			{
				return "android.intent.action.DATE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_TIMEZONE_CHANGED
		{
			get
			{
				return "android.intent.action.TIMEZONE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BOOT_COMPLETED
		{
			get
			{
				return "android.intent.action.BOOT_COMPLETED";
			}
		}
		public static global::java.lang.String ACTION_CLOSE_SYSTEM_DIALOGS
		{
			get
			{
				return "android.intent.action.CLOSE_SYSTEM_DIALOGS";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_INSTALL
		{
			get
			{
				return "android.intent.action.PACKAGE_INSTALL";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_ADDED
		{
			get
			{
				return "android.intent.action.PACKAGE_ADDED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_REPLACED
		{
			get
			{
				return "android.intent.action.PACKAGE_REPLACED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_REMOVED
		{
			get
			{
				return "android.intent.action.PACKAGE_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_CHANGED
		{
			get
			{
				return "android.intent.action.PACKAGE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_RESTARTED
		{
			get
			{
				return "android.intent.action.PACKAGE_RESTARTED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_DATA_CLEARED
		{
			get
			{
				return "android.intent.action.PACKAGE_DATA_CLEARED";
			}
		}
		public static global::java.lang.String ACTION_UID_REMOVED
		{
			get
			{
				return "android.intent.action.UID_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_EXTERNAL_APPLICATIONS_AVAILABLE
		{
			get
			{
				return "android.intent.action.EXTERNAL_APPLICATIONS_AVAILABLE";
			}
		}
		public static global::java.lang.String ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE
		{
			get
			{
				return "android.intent.action.EXTERNAL_APPLICATIONS_UNAVAILABLE";
			}
		}
		public static global::java.lang.String ACTION_WALLPAPER_CHANGED
		{
			get
			{
				return "android.intent.action.WALLPAPER_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_CONFIGURATION_CHANGED
		{
			get
			{
				return "android.intent.action.CONFIGURATION_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_LOCALE_CHANGED
		{
			get
			{
				return "android.intent.action.LOCALE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_CHANGED
		{
			get
			{
				return "android.intent.action.BATTERY_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_LOW
		{
			get
			{
				return "android.intent.action.BATTERY_LOW";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_OKAY
		{
			get
			{
				return "android.intent.action.BATTERY_OKAY";
			}
		}
		public static global::java.lang.String ACTION_POWER_CONNECTED
		{
			get
			{
				return "android.intent.action.ACTION_POWER_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_POWER_DISCONNECTED
		{
			get
			{
				return "android.intent.action.ACTION_POWER_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_SHUTDOWN
		{
			get
			{
				return "android.intent.action.ACTION_SHUTDOWN";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_STORAGE_LOW
		{
			get
			{
				return "android.intent.action.DEVICE_STORAGE_LOW";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_STORAGE_OK
		{
			get
			{
				return "android.intent.action.DEVICE_STORAGE_OK";
			}
		}
		public static global::java.lang.String ACTION_MANAGE_PACKAGE_STORAGE
		{
			get
			{
				return "android.intent.action.MANAGE_PACKAGE_STORAGE";
			}
		}
		public static global::java.lang.String ACTION_UMS_CONNECTED
		{
			get
			{
				return "android.intent.action.UMS_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_UMS_DISCONNECTED
		{
			get
			{
				return "android.intent.action.UMS_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_REMOVED
		{
			get
			{
				return "android.intent.action.MEDIA_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_UNMOUNTED
		{
			get
			{
				return "android.intent.action.MEDIA_UNMOUNTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_CHECKING
		{
			get
			{
				return "android.intent.action.MEDIA_CHECKING";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_NOFS
		{
			get
			{
				return "android.intent.action.MEDIA_NOFS";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_MOUNTED
		{
			get
			{
				return "android.intent.action.MEDIA_MOUNTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SHARED
		{
			get
			{
				return "android.intent.action.MEDIA_SHARED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_BAD_REMOVAL
		{
			get
			{
				return "android.intent.action.MEDIA_BAD_REMOVAL";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_UNMOUNTABLE
		{
			get
			{
				return "android.intent.action.MEDIA_UNMOUNTABLE";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_EJECT
		{
			get
			{
				return "android.intent.action.MEDIA_EJECT";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_STARTED
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_STARTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_FINISHED
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_FINISHED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_SCAN_FILE
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_SCAN_FILE";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_BUTTON
		{
			get
			{
				return "android.intent.action.MEDIA_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_CAMERA_BUTTON
		{
			get
			{
				return "android.intent.action.CAMERA_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_GTALK_SERVICE_CONNECTED
		{
			get
			{
				return "android.intent.action.GTALK_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_GTALK_SERVICE_DISCONNECTED
		{
			get
			{
				return "android.intent.action.GTALK_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_INPUT_METHOD_CHANGED
		{
			get
			{
				return "android.intent.action.INPUT_METHOD_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_AIRPLANE_MODE_CHANGED
		{
			get
			{
				return "android.intent.action.AIRPLANE_MODE";
			}
		}
		public static global::java.lang.String ACTION_PROVIDER_CHANGED
		{
			get
			{
				return "android.intent.action.PROVIDER_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_HEADSET_PLUG
		{
			get
			{
				return "android.intent.action.HEADSET_PLUG";
			}
		}
		public static global::java.lang.String ACTION_NEW_OUTGOING_CALL
		{
			get
			{
				return "android.intent.action.NEW_OUTGOING_CALL";
			}
		}
		public static global::java.lang.String ACTION_REBOOT
		{
			get
			{
				return "android.intent.action.REBOOT";
			}
		}
		public static global::java.lang.String ACTION_DOCK_EVENT
		{
			get
			{
				return "android.intent.action.DOCK_EVENT";
			}
		}
		public static global::java.lang.String CATEGORY_DEFAULT
		{
			get
			{
				return "android.intent.category.DEFAULT";
			}
		}
		public static global::java.lang.String CATEGORY_BROWSABLE
		{
			get
			{
				return "android.intent.category.BROWSABLE";
			}
		}
		public static global::java.lang.String CATEGORY_ALTERNATIVE
		{
			get
			{
				return "android.intent.category.ALTERNATIVE";
			}
		}
		public static global::java.lang.String CATEGORY_SELECTED_ALTERNATIVE
		{
			get
			{
				return "android.intent.category.SELECTED_ALTERNATIVE";
			}
		}
		public static global::java.lang.String CATEGORY_TAB
		{
			get
			{
				return "android.intent.category.TAB";
			}
		}
		public static global::java.lang.String CATEGORY_LAUNCHER
		{
			get
			{
				return "android.intent.category.LAUNCHER";
			}
		}
		public static global::java.lang.String CATEGORY_INFO
		{
			get
			{
				return "android.intent.category.INFO";
			}
		}
		public static global::java.lang.String CATEGORY_HOME
		{
			get
			{
				return "android.intent.category.HOME";
			}
		}
		public static global::java.lang.String CATEGORY_PREFERENCE
		{
			get
			{
				return "android.intent.category.PREFERENCE";
			}
		}
		public static global::java.lang.String CATEGORY_DEVELOPMENT_PREFERENCE
		{
			get
			{
				return "android.intent.category.DEVELOPMENT_PREFERENCE";
			}
		}
		public static global::java.lang.String CATEGORY_EMBED
		{
			get
			{
				return "android.intent.category.EMBED";
			}
		}
		public static global::java.lang.String CATEGORY_MONKEY
		{
			get
			{
				return "android.intent.category.MONKEY";
			}
		}
		public static global::java.lang.String CATEGORY_TEST
		{
			get
			{
				return "android.intent.category.TEST";
			}
		}
		public static global::java.lang.String CATEGORY_UNIT_TEST
		{
			get
			{
				return "android.intent.category.UNIT_TEST";
			}
		}
		public static global::java.lang.String CATEGORY_SAMPLE_CODE
		{
			get
			{
				return "android.intent.category.SAMPLE_CODE";
			}
		}
		public static global::java.lang.String CATEGORY_OPENABLE
		{
			get
			{
				return "android.intent.category.OPENABLE";
			}
		}
		public static global::java.lang.String CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST
		{
			get
			{
				return "android.intent.category.FRAMEWORK_INSTRUMENTATION_TEST";
			}
		}
		public static global::java.lang.String CATEGORY_CAR_DOCK
		{
			get
			{
				return "android.intent.category.CAR_DOCK";
			}
		}
		public static global::java.lang.String CATEGORY_DESK_DOCK
		{
			get
			{
				return "android.intent.category.DESK_DOCK";
			}
		}
		public static global::java.lang.String CATEGORY_CAR_MODE
		{
			get
			{
				return "android.intent.category.CAR_MODE";
			}
		}
		public static global::java.lang.String EXTRA_TEMPLATE
		{
			get
			{
				return "android.intent.extra.TEMPLATE";
			}
		}
		public static global::java.lang.String EXTRA_TEXT
		{
			get
			{
				return "android.intent.extra.TEXT";
			}
		}
		public static global::java.lang.String EXTRA_STREAM
		{
			get
			{
				return "android.intent.extra.STREAM";
			}
		}
		public static global::java.lang.String EXTRA_EMAIL
		{
			get
			{
				return "android.intent.extra.EMAIL";
			}
		}
		public static global::java.lang.String EXTRA_CC
		{
			get
			{
				return "android.intent.extra.CC";
			}
		}
		public static global::java.lang.String EXTRA_BCC
		{
			get
			{
				return "android.intent.extra.BCC";
			}
		}
		public static global::java.lang.String EXTRA_SUBJECT
		{
			get
			{
				return "android.intent.extra.SUBJECT";
			}
		}
		public static global::java.lang.String EXTRA_INTENT
		{
			get
			{
				return "android.intent.extra.INTENT";
			}
		}
		public static global::java.lang.String EXTRA_TITLE
		{
			get
			{
				return "android.intent.extra.TITLE";
			}
		}
		public static global::java.lang.String EXTRA_INITIAL_INTENTS
		{
			get
			{
				return "android.intent.extra.INITIAL_INTENTS";
			}
		}
		public static global::java.lang.String EXTRA_KEY_EVENT
		{
			get
			{
				return "android.intent.extra.KEY_EVENT";
			}
		}
		public static global::java.lang.String EXTRA_DONT_KILL_APP
		{
			get
			{
				return "android.intent.extra.DONT_KILL_APP";
			}
		}
		public static global::java.lang.String EXTRA_PHONE_NUMBER
		{
			get
			{
				return "android.intent.extra.PHONE_NUMBER";
			}
		}
		public static global::java.lang.String EXTRA_UID
		{
			get
			{
				return "android.intent.extra.UID";
			}
		}
		public static global::java.lang.String EXTRA_DATA_REMOVED
		{
			get
			{
				return "android.intent.extra.DATA_REMOVED";
			}
		}
		public static global::java.lang.String EXTRA_REPLACING
		{
			get
			{
				return "android.intent.extra.REPLACING";
			}
		}
		public static global::java.lang.String EXTRA_ALARM_COUNT
		{
			get
			{
				return "android.intent.extra.ALARM_COUNT";
			}
		}
		public static global::java.lang.String EXTRA_DOCK_STATE
		{
			get
			{
				return "android.intent.extra.DOCK_STATE";
			}
		}
		public static int EXTRA_DOCK_STATE_UNDOCKED
		{
			get
			{
				return 0;
			}
		}
		public static int EXTRA_DOCK_STATE_DESK
		{
			get
			{
				return 1;
			}
		}
		public static int EXTRA_DOCK_STATE_CAR
		{
			get
			{
				return 2;
			}
		}
		public static global::java.lang.String METADATA_DOCK_HOME
		{
			get
			{
				return "android.dock_home";
			}
		}
		public static global::java.lang.String EXTRA_REMOTE_INTENT_TOKEN
		{
			get
			{
				return "android.intent.extra.remote_intent_token";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_COMPONENT_NAME
		{
			get
			{
				return "android.intent.extra.changed_component_name";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_COMPONENT_NAME_LIST
		{
			get
			{
				return "android.intent.extra.changed_component_name_list";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_PACKAGE_LIST
		{
			get
			{
				return "android.intent.extra.changed_package_list";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_UID_LIST
		{
			get
			{
				return "android.intent.extra.changed_uid_list";
			}
		}
		public static int FLAG_GRANT_READ_URI_PERMISSION
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_GRANT_WRITE_URI_PERMISSION
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_FROM_BACKGROUND
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_DEBUG_LOG_RESOLUTION
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_ACTIVITY_NO_HISTORY
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_ACTIVITY_SINGLE_TOP
		{
			get
			{
				return 536870912;
			}
		}
		public static int FLAG_ACTIVITY_NEW_TASK
		{
			get
			{
				return 268435456;
			}
		}
		public static int FLAG_ACTIVITY_MULTIPLE_TASK
		{
			get
			{
				return 134217728;
			}
		}
		public static int FLAG_ACTIVITY_CLEAR_TOP
		{
			get
			{
				return 67108864;
			}
		}
		public static int FLAG_ACTIVITY_FORWARD_RESULT
		{
			get
			{
				return 33554432;
			}
		}
		public static int FLAG_ACTIVITY_PREVIOUS_IS_TOP
		{
			get
			{
				return 16777216;
			}
		}
		public static int FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS
		{
			get
			{
				return 8388608;
			}
		}
		public static int FLAG_ACTIVITY_BROUGHT_TO_FRONT
		{
			get
			{
				return 4194304;
			}
		}
		public static int FLAG_ACTIVITY_RESET_TASK_IF_NEEDED
		{
			get
			{
				return 2097152;
			}
		}
		public static int FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY
		{
			get
			{
				return 1048576;
			}
		}
		public static int FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET
		{
			get
			{
				return 524288;
			}
		}
		public static int FLAG_ACTIVITY_NO_USER_ACTION
		{
			get
			{
				return 262144;
			}
		}
		public static int FLAG_ACTIVITY_REORDER_TO_FRONT
		{
			get
			{
				return 131072;
			}
		}
		public static int FLAG_ACTIVITY_NO_ANIMATION
		{
			get
			{
				return 65536;
			}
		}
		public static int FLAG_RECEIVER_REGISTERED_ONLY
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_RECEIVER_REPLACE_PENDING
		{
			get
			{
				return 536870912;
			}
		}
		public static int URI_INTENT_SCHEME
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_IN_ACTION
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_IN_DATA
		{
			get
			{
				return 2;
			}
		}
		public static int FILL_IN_CATEGORIES
		{
			get
			{
				return 4;
			}
		}
		public static int FILL_IN_COMPONENT
		{
			get
			{
				return 8;
			}
		}
		public static int FILL_IN_PACKAGE
		{
			get
			{
				return 16;
			}
		}
		public static int FILL_IN_SOURCE_BOUNDS
		{
			get
			{
				return 32;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3382;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.Intent.staticClass, _CREATOR3382)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Intent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent"));
			global::android.content.Intent._toString3098 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.Intent._clone3099 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.content.Intent._getPackage3100 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getPackage", "()Ljava/lang/String;");
			global::android.content.Intent._getType3101 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getType", "()Ljava/lang/String;");
			global::android.content.Intent._toURI3102 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "toURI", "()Ljava/lang/String;");
			global::android.content.Intent._getScheme3103 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getScheme", "()Ljava/lang/String;");
			global::android.content.Intent._getData3104 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getData", "()Landroid/net/Uri;");
			global::android.content.Intent._getComponent3105 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.content.Intent._setClassName3106 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setClassName", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setClassName3107 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setClassName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._writeToParcel3108 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.Intent._describeContents3109 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "describeContents", "()I");
			global::android.content.Intent._createChooser3110 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;");
			global::android.content.Intent._cloneFilter3111 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "cloneFilter", "()Landroid/content/Intent;");
			global::android.content.Intent._getIntent3112 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._parseUri3113 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;");
			global::android.content.Intent._getIntentOld3114 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._getAction3115 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getAction", "()Ljava/lang/String;");
			global::android.content.Intent._getDataString3116 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getDataString", "()Ljava/lang/String;");
			global::android.content.Intent._resolveType3117 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.content.Intent._resolveType3118 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			global::android.content.Intent._resolveTypeIfNeeded3119 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			global::android.content.Intent._hasCategory3120 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "hasCategory", "(Ljava/lang/String;)Z");
			global::android.content.Intent._getCategories3121 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCategories", "()Ljava/util/Set;");
			global::android.content.Intent._setExtrasClassLoader3122 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::android.content.Intent._hasExtra3123 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "hasExtra", "(Ljava/lang/String;)Z");
			global::android.content.Intent._hasFileDescriptors3124 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "hasFileDescriptors", "()Z");
			global::android.content.Intent._getBooleanExtra3125 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getBooleanExtra", "(Ljava/lang/String;Z)Z");
			global::android.content.Intent._getByteExtra3126 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getByteExtra", "(Ljava/lang/String;B)B");
			global::android.content.Intent._getShortExtra3127 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getShortExtra", "(Ljava/lang/String;S)S");
			global::android.content.Intent._getCharExtra3128 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharExtra", "(Ljava/lang/String;C)C");
			global::android.content.Intent._getIntExtra3129 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntExtra", "(Ljava/lang/String;I)I");
			global::android.content.Intent._getLongExtra3130 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getLongExtra", "(Ljava/lang/String;J)J");
			global::android.content.Intent._getFloatExtra3131 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getFloatExtra", "(Ljava/lang/String;F)F");
			global::android.content.Intent._getDoubleExtra3132 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getDoubleExtra", "(Ljava/lang/String;D)D");
			global::android.content.Intent._getStringExtra3133 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.Intent._getCharSequenceExtra3134 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.content.Intent._getParcelableExtra3135 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			global::android.content.Intent._getParcelableArrayExtra3136 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;");
			global::android.content.Intent._getParcelableArrayListExtra3137 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getSerializableExtra3138 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;");
			global::android.content.Intent._getIntegerArrayListExtra3139 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getStringArrayListExtra3140 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getCharSequenceArrayListExtra3141 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharSequenceArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getBooleanArrayExtra3142 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getBooleanArrayExtra", "(Ljava/lang/String;)[Z");
			global::android.content.Intent._getByteArrayExtra3143 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getByteArrayExtra", "(Ljava/lang/String;)[B");
			global::android.content.Intent._getShortArrayExtra3144 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getShortArrayExtra", "(Ljava/lang/String;)[S");
			global::android.content.Intent._getCharArrayExtra3145 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharArrayExtra", "(Ljava/lang/String;)[C");
			global::android.content.Intent._getIntArrayExtra3146 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntArrayExtra", "(Ljava/lang/String;)[I");
			global::android.content.Intent._getLongArrayExtra3147 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getLongArrayExtra", "(Ljava/lang/String;)[J");
			global::android.content.Intent._getFloatArrayExtra3148 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getFloatArrayExtra", "(Ljava/lang/String;)[F");
			global::android.content.Intent._getDoubleArrayExtra3149 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getDoubleArrayExtra", "(Ljava/lang/String;)[D");
			global::android.content.Intent._getStringArrayExtra3150 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.Intent._getCharSequenceArrayExtra3151 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharSequenceArrayExtra", "(Ljava/lang/String;)[Ljava/lang/CharSequence;");
			global::android.content.Intent._getBundleExtra3152 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.content.Intent._getExtras3153 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.content.Intent._getFlags3154 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getFlags", "()I");
			global::android.content.Intent._getSourceBounds3155 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getSourceBounds", "()Landroid/graphics/Rect;");
			global::android.content.Intent._resolveActivity3156 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;");
			global::android.content.Intent._resolveActivityInfo3157 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.Intent._setAction3158 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setAction", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setData3159 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setData", "(Landroid/net/Uri;)Landroid/content/Intent;");
			global::android.content.Intent._setType3160 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setType", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setDataAndType3161 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._addCategory3162 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "addCategory", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._removeCategory3163 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "removeCategory", "(Ljava/lang/String;)V");
			global::android.content.Intent._putExtra3164 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Z)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3165 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Z)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3166 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3167 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;C)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3168 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;S)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3169 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;I)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3170 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;J)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3171 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;F)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3172 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;D)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3173 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3174 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/CharSequence;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3175 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Parcelable;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3176 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3177 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3178 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3179 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[S)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3180 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[C)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3181 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[I)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3182 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[J)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3183 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[F)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3184 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[D)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3185 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3186 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/CharSequence;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra3187 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;");
			global::android.content.Intent._putParcelableArrayListExtra3188 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putIntegerArrayListExtra3189 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putStringArrayListExtra3190 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putCharSequenceArrayListExtra3191 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putCharSequenceArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putExtras3192 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;");
			global::android.content.Intent._putExtras3193 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;");
			global::android.content.Intent._replaceExtras3194 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;");
			global::android.content.Intent._replaceExtras3195 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;");
			global::android.content.Intent._removeExtra3196 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "removeExtra", "(Ljava/lang/String;)V");
			global::android.content.Intent._setFlags3197 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setFlags", "(I)Landroid/content/Intent;");
			global::android.content.Intent._addFlags3198 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "addFlags", "(I)Landroid/content/Intent;");
			global::android.content.Intent._setPackage3199 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setComponent3200 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;");
			global::android.content.Intent._setClass3201 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;");
			global::android.content.Intent._setSourceBounds3202 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setSourceBounds", "(Landroid/graphics/Rect;)V");
			global::android.content.Intent._fillIn3203 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "fillIn", "(Landroid/content/Intent;I)I");
			global::android.content.Intent._filterEquals3204 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "filterEquals", "(Landroid/content/Intent;)Z");
			global::android.content.Intent._filterHashCode3205 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "filterHashCode", "()I");
			global::android.content.Intent._toUri3206 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "toUri", "(I)Ljava/lang/String;");
			global::android.content.Intent._readFromParcel3207 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.Intent._parseIntent3208 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/content/Intent;");
			global::android.content.Intent._Intent3209 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "()V");
			global::android.content.Intent._Intent3210 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Intent;)V");
			global::android.content.Intent._Intent3211 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.Intent._Intent3212 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;)V");
			global::android.content.Intent._Intent3213 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::android.content.Intent._Intent3214 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V");
			global::android.content.Intent._CREATOR3382 = @__env.GetStaticFieldIDNoThrow(global::android.content.Intent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
