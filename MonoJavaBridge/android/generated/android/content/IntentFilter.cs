namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IntentFilter : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntentFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AuthorityEntry : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal static global::MonoJavaBridge.MethodId _getPort3397;
			public int getPort()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.AuthorityEntry._getPort3397.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.AuthorityEntry._getPort3397 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I");
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getPort3397);
			}
			public new global::java.lang.String Host
			{
				get
				{
					return getHost();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHost3398;
			public global::java.lang.String getHost()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.AuthorityEntry._getHost3398.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.AuthorityEntry._getHost3398 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getHost3398)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _match3399;
			public int match(android.net.Uri arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.AuthorityEntry._match3399.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.AuthorityEntry._match3399 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I");
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._match3399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AuthorityEntry3400;
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry3400.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry3400 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry3400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static AuthorityEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$AuthorityEntry"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MalformedMimeTypeException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MalformedMimeTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _MalformedMimeTypeException3401;
			public MalformedMimeTypeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3401.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3401 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3401);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MalformedMimeTypeException3402;
			public MalformedMimeTypeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3402.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3402 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException3402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static MalformedMimeTypeException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$MalformedMimeTypeException"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPriority3403;
		public virtual void setPriority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._setPriority3403.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._setPriority3403 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "setPriority", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._setPriority3403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPriority3404;
		public virtual int getPriority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getPriority3404.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getPriority3404 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getPriority", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getPriority3404);
		}
		internal static global::MonoJavaBridge.MethodId _create3405;
		public static global::android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._create3405.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._create3405 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._create3405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.IntentFilter;
		}
		internal static global::MonoJavaBridge.MethodId _match3406;
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._match3406.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._match3406 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match3406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _match3407;
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._match3407.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._match3407 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match3407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dump3408;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._dump3408.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._dump3408 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._dump3408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3409;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._writeToParcel3409.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._writeToParcel3409 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToParcel3409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3410;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._describeContents3410.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._describeContents3410 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._describeContents3410);
		}
		internal static global::MonoJavaBridge.MethodId _getAction3411;
		public virtual global::java.lang.String getAction(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getAction3411.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getAction3411 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getAction3411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasCategory3412;
		public virtual bool hasCategory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._hasCategory3412.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._hasCategory3412 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasCategory3412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCategory3413;
		public virtual void addCategory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._addCategory3413.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._addCategory3413 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addCategory3413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAction3414;
		public virtual void addAction(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._addAction3414.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._addAction3414 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addAction3414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countActions3415;
		public virtual int countActions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._countActions3415.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._countActions3415 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countActions", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countActions3415);
		}
		internal static global::MonoJavaBridge.MethodId _hasAction3416;
		public virtual bool hasAction(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._hasAction3416.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._hasAction3416 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasAction3416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchAction3417;
		public virtual bool matchAction(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._matchAction3417.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._matchAction3417 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchAction3417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _actionsIterator3418;
		public virtual global::java.util.Iterator actionsIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._actionsIterator3418.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._actionsIterator3418 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._actionsIterator3418) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataType3419;
		public virtual void addDataType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._addDataType3419.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._addDataType3419 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataType3419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasDataType3420;
		public virtual bool hasDataType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._hasDataType3420.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._hasDataType3420 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataType3420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countDataTypes3421;
		public virtual int countDataTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._countDataTypes3421.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._countDataTypes3421 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataTypes", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataTypes3421);
		}
		internal static global::MonoJavaBridge.MethodId _getDataType3422;
		public virtual global::java.lang.String getDataType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getDataType3422.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getDataType3422 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataType3422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _typesIterator3423;
		public virtual global::java.util.Iterator typesIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._typesIterator3423.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._typesIterator3423 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._typesIterator3423) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataScheme3424;
		public virtual void addDataScheme(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._addDataScheme3424.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._addDataScheme3424 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataScheme3424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countDataSchemes3425;
		public virtual int countDataSchemes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._countDataSchemes3425.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._countDataSchemes3425 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataSchemes3425);
		}
		internal static global::MonoJavaBridge.MethodId _getDataScheme3426;
		public virtual global::java.lang.String getDataScheme(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getDataScheme3426.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getDataScheme3426 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataScheme3426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataScheme3427;
		public virtual bool hasDataScheme(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._hasDataScheme3427.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._hasDataScheme3427 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataScheme3427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _schemesIterator3428;
		public virtual global::java.util.Iterator schemesIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._schemesIterator3428.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._schemesIterator3428 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._schemesIterator3428) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataAuthority3429;
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._addDataAuthority3429.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._addDataAuthority3429 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataAuthority3429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDataAuthorities3430;
		public virtual int countDataAuthorities()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._countDataAuthorities3430.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._countDataAuthorities3430 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataAuthorities3430);
		}
		internal static global::MonoJavaBridge.MethodId _getDataAuthority3431;
		public virtual global::android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getDataAuthority3431.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getDataAuthority3431 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.IntentFilter.AuthorityEntry>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataAuthority3431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.IntentFilter.AuthorityEntry;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataAuthority3432;
		public virtual bool hasDataAuthority(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._hasDataAuthority3432.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._hasDataAuthority3432 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataAuthority3432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _authoritiesIterator3433;
		public virtual global::java.util.Iterator authoritiesIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._authoritiesIterator3433.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._authoritiesIterator3433 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._authoritiesIterator3433) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataPath3434;
		public virtual void addDataPath(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._addDataPath3434.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._addDataPath3434 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataPath3434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDataPaths3435;
		public virtual int countDataPaths()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._countDataPaths3435.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._countDataPaths3435 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataPaths", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataPaths3435);
		}
		internal static global::MonoJavaBridge.MethodId _getDataPath3436;
		public virtual global::android.os.PatternMatcher getDataPath(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getDataPath3436.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getDataPath3436 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataPath3436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.PatternMatcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataPath3437;
		public virtual bool hasDataPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._hasDataPath3437.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._hasDataPath3437 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataPath3437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pathsIterator3438;
		public virtual global::java.util.Iterator pathsIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._pathsIterator3438.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._pathsIterator3438 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._pathsIterator3438) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _matchDataAuthority3439;
		public virtual int matchDataAuthority(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._matchDataAuthority3439.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._matchDataAuthority3439 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchDataAuthority3439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchData3440;
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._matchData3440.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._matchData3440 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchData3440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _countCategories3441;
		public virtual int countCategories()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._countCategories3441.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._countCategories3441 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countCategories", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countCategories3441);
		}
		internal static global::MonoJavaBridge.MethodId _getCategory3442;
		public virtual global::java.lang.String getCategory(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._getCategory3442.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._getCategory3442 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getCategory3442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _categoriesIterator3443;
		public virtual global::java.util.Iterator categoriesIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._categoriesIterator3443.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._categoriesIterator3443 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._categoriesIterator3443) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _matchCategories3444;
		public virtual global::java.lang.String matchCategories(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._matchCategories3444.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._matchCategories3444 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchCategories3444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToXml3445;
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._writeToXml3445.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._writeToXml3445 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToXml3445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFromXml3446;
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._readFromXml3446.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._readFromXml3446 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._readFromXml3446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3447;
		public IntentFilter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._IntentFilter3447.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._IntentFilter3447 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3447);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3448;
		public IntentFilter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._IntentFilter3448.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._IntentFilter3448 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3449;
		public IntentFilter(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._IntentFilter3449.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._IntentFilter3449 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter3450;
		public IntentFilter(android.content.IntentFilter arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._IntentFilter3450.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._IntentFilter3450 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter3450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR3466;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.IntentFilter.staticClass, _CREATOR3466)) as android.os.Parcelable_Creator;
			}
		}
		static IntentFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.IntentFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter"));
			global::android.content.IntentFilter._CREATOR3466 = @__env.GetStaticFieldIDNoThrow(global::android.content.IntentFilter.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
