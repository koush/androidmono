namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IntentFilter : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntentFilter()
		{
			InitJNI();
		}
		protected IntentFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AuthorityEntry : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AuthorityEntry()
			{
				InitJNI();
			}
			internal AuthorityEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new int Port
			{
				get
				{
					return getPort();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPort3383;
			public int getPort() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry._getPort3383);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getPort3383);
			}
			public new global::java.lang.String Host
			{
				get
				{
					return getHost();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHost3384;
			public global::java.lang.String getHost() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry._getHost3384)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getHost3384)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _match3385;
			public int match(android.net.Uri arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry._match3385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._match3385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AuthorityEntry3386;
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry3386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$AuthorityEntry"));
				global::android.content.IntentFilter.AuthorityEntry._getPort3383 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I");
				global::android.content.IntentFilter.AuthorityEntry._getHost3384 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;");
				global::android.content.IntentFilter.AuthorityEntry._match3385 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I");
				global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry3386 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MalformedMimeTypeException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MalformedMimeTypeException()
			{
				InitJNI();
			}
			protected MalformedMimeTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _MalformedMimeTypeException3387;
			public MalformedMimeTypeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3387);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MalformedMimeTypeException3388;
			public MalformedMimeTypeException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$MalformedMimeTypeException"));
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3387 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V");
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3388 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPriority3389;
		public virtual void setPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._setPriority3389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._setPriority3389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Priority
		{
			get
			{
				return getPriority();
			}
			set
			{
				setPriority(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPriority3390;
		public virtual int getPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._getPriority3390);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getPriority3390);
		}
		internal static global::MonoJavaBridge.MethodId _create3391;
		public static global::android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._create3391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.IntentFilter;
		}
		internal static global::MonoJavaBridge.MethodId _match3392;
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._match3392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match3392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _match3393;
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._match3393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match3393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dump3394;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._dump3394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._dump3394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3395;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._writeToParcel3395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToParcel3395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3396;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._describeContents3396);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._describeContents3396);
		}
		internal static global::MonoJavaBridge.MethodId _getAction3397;
		public virtual global::java.lang.String getAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getAction3397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getAction3397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasCategory3398;
		public virtual bool hasCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasCategory3398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasCategory3398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCategory3399;
		public virtual void addCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addCategory3399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addCategory3399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAction3400;
		public virtual void addAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addAction3400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addAction3400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countActions3401;
		public virtual int countActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countActions3401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countActions3401);
		}
		internal static global::MonoJavaBridge.MethodId _hasAction3402;
		public virtual bool hasAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasAction3402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasAction3402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchAction3403;
		public virtual bool matchAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._matchAction3403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchAction3403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _actionsIterator3404;
		public virtual global::java.util.Iterator actionsIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._actionsIterator3404)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._actionsIterator3404)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataType3405;
		public virtual void addDataType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataType3405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataType3405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasDataType3406;
		public virtual bool hasDataType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataType3406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataType3406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countDataTypes3407;
		public virtual int countDataTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataTypes3407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataTypes3407);
		}
		internal static global::MonoJavaBridge.MethodId _getDataType3408;
		public virtual global::java.lang.String getDataType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataType3408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataType3408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _typesIterator3409;
		public virtual global::java.util.Iterator typesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._typesIterator3409)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._typesIterator3409)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataScheme3410;
		public virtual void addDataScheme(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataScheme3410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataScheme3410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countDataSchemes3411;
		public virtual int countDataSchemes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataSchemes3411);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataSchemes3411);
		}
		internal static global::MonoJavaBridge.MethodId _getDataScheme3412;
		public virtual global::java.lang.String getDataScheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataScheme3412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataScheme3412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataScheme3413;
		public virtual bool hasDataScheme(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataScheme3413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataScheme3413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _schemesIterator3414;
		public virtual global::java.util.Iterator schemesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._schemesIterator3414)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._schemesIterator3414)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataAuthority3415;
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataAuthority3415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataAuthority3415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDataAuthorities3416;
		public virtual int countDataAuthorities() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataAuthorities3416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataAuthorities3416);
		}
		internal static global::MonoJavaBridge.MethodId _getDataAuthority3417;
		public virtual global::android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.IntentFilter.AuthorityEntry>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataAuthority3417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentFilter.AuthorityEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.IntentFilter.AuthorityEntry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataAuthority3417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentFilter.AuthorityEntry;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataAuthority3418;
		public virtual bool hasDataAuthority(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataAuthority3418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataAuthority3418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _authoritiesIterator3419;
		public virtual global::java.util.Iterator authoritiesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._authoritiesIterator3419)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._authoritiesIterator3419)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataPath3420;
		public virtual void addDataPath(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataPath3420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataPath3420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDataPaths3421;
		public virtual int countDataPaths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataPaths3421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataPaths3421);
		}
		internal static global::MonoJavaBridge.MethodId _getDataPath3422;
		public virtual global::android.os.PatternMatcher getDataPath(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataPath3422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.PatternMatcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataPath3422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.PatternMatcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataPath3423;
		public virtual bool hasDataPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataPath3423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataPath3423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pathsIterator3424;
		public virtual global::java.util.Iterator pathsIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._pathsIterator3424)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._pathsIterator3424)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _matchDataAuthority3425;
		public virtual int matchDataAuthority(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._matchDataAuthority3425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchDataAuthority3425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchData3426;
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._matchData3426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchData3426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _countCategories3427;
		public virtual int countCategories() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countCategories3427);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countCategories3427);
		}
		internal static global::MonoJavaBridge.MethodId _getCategory3428;
		public virtual global::java.lang.String getCategory(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getCategory3428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getCategory3428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _categoriesIterator3429;
		public virtual global::java.util.Iterator categoriesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._categoriesIterator3429)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._categoriesIterator3429)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _matchCategories3430;
		public virtual global::java.lang.String matchCategories(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._matchCategories3430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchCategories3430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToXml3431;
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._writeToXml3431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToXml3431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFromXml3432;
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._readFromXml3432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._readFromXml3432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3433;
		public IntentFilter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3433);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3434;
		public IntentFilter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3435;
		public IntentFilter(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3436;
		public IntentFilter(android.content.IntentFilter arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int SYSTEM_HIGH_PRIORITY
		{
			get
			{
				return 1000;
			}
		}
		public static int SYSTEM_LOW_PRIORITY
		{
			get
			{
				return -1000;
			}
		}
		public static int MATCH_CATEGORY_MASK
		{
			get
			{
				return 268369920;
			}
		}
		public static int MATCH_ADJUSTMENT_MASK
		{
			get
			{
				return 65535;
			}
		}
		public static int MATCH_ADJUSTMENT_NORMAL
		{
			get
			{
				return 32768;
			}
		}
		public static int MATCH_CATEGORY_EMPTY
		{
			get
			{
				return 1048576;
			}
		}
		public static int MATCH_CATEGORY_SCHEME
		{
			get
			{
				return 2097152;
			}
		}
		public static int MATCH_CATEGORY_HOST
		{
			get
			{
				return 3145728;
			}
		}
		public static int MATCH_CATEGORY_PORT
		{
			get
			{
				return 4194304;
			}
		}
		public static int MATCH_CATEGORY_PATH
		{
			get
			{
				return 5242880;
			}
		}
		public static int MATCH_CATEGORY_TYPE
		{
			get
			{
				return 6291456;
			}
		}
		public static int NO_MATCH_TYPE
		{
			get
			{
				return -1;
			}
		}
		public static int NO_MATCH_DATA
		{
			get
			{
				return -2;
			}
		}
		public static int NO_MATCH_ACTION
		{
			get
			{
				return -3;
			}
		}
		public static int NO_MATCH_CATEGORY
		{
			get
			{
				return -4;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3452;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.IntentFilter.staticClass, _CREATOR3452)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.IntentFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter"));
			global::android.content.IntentFilter._setPriority3389 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "setPriority", "(I)V");
			global::android.content.IntentFilter._getPriority3390 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getPriority", "()I");
			global::android.content.IntentFilter._create3391 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;");
			global::android.content.IntentFilter._match3392 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I");
			global::android.content.IntentFilter._match3393 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I");
			global::android.content.IntentFilter._dump3394 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.IntentFilter._writeToParcel3395 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.IntentFilter._describeContents3396 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "describeContents", "()I");
			global::android.content.IntentFilter._getAction3397 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._hasCategory3398 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._addCategory3399 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._addAction3400 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._countActions3401 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countActions", "()I");
			global::android.content.IntentFilter._hasAction3402 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._matchAction3403 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._actionsIterator3404 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataType3405 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._hasDataType3406 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._countDataTypes3407 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataTypes", "()I");
			global::android.content.IntentFilter._getDataType3408 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._typesIterator3409 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataScheme3410 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._countDataSchemes3411 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I");
			global::android.content.IntentFilter._getDataScheme3412 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._hasDataScheme3413 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._schemesIterator3414 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataAuthority3415 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.IntentFilter._countDataAuthorities3416 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I");
			global::android.content.IntentFilter._getDataAuthority3417 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;");
			global::android.content.IntentFilter._hasDataAuthority3418 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z");
			global::android.content.IntentFilter._authoritiesIterator3419 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataPath3420 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V");
			global::android.content.IntentFilter._countDataPaths3421 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataPaths", "()I");
			global::android.content.IntentFilter._getDataPath3422 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;");
			global::android.content.IntentFilter._hasDataPath3423 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._pathsIterator3424 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._matchDataAuthority3425 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I");
			global::android.content.IntentFilter._matchData3426 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I");
			global::android.content.IntentFilter._countCategories3427 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countCategories", "()I");
			global::android.content.IntentFilter._getCategory3428 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._categoriesIterator3429 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._matchCategories3430 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;");
			global::android.content.IntentFilter._writeToXml3431 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V");
			global::android.content.IntentFilter._readFromXml3432 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::android.content.IntentFilter._IntentFilter3433 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "()V");
			global::android.content.IntentFilter._IntentFilter3434 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._IntentFilter3435 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.IntentFilter._IntentFilter3436 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V");
			global::android.content.IntentFilter._CREATOR3452 = @__env.GetStaticFieldIDNoThrow(global::android.content.IntentFilter.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
