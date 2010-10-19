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
			internal static global::MonoJavaBridge.MethodId _getPort1660;
			public int getPort() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry._getPort1660);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getPort1660);
			}
			public new global::java.lang.String Host
			{
				get
				{
					return getHost();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHost1661;
			public global::java.lang.String getHost() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry._getHost1661)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getHost1661)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _match1662;
			public int match(android.net.Uri arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry._match1662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._match1662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AuthorityEntry1663;
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$AuthorityEntry"));
				global::android.content.IntentFilter.AuthorityEntry._getPort1660 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I");
				global::android.content.IntentFilter.AuthorityEntry._getHost1661 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;");
				global::android.content.IntentFilter.AuthorityEntry._match1662 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I");
				global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1663 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
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
			internal static global::MonoJavaBridge.MethodId _MalformedMimeTypeException1664;
			public MalformedMimeTypeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1664);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MalformedMimeTypeException1665;
			public MalformedMimeTypeException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$MalformedMimeTypeException"));
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1664 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V");
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1665 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPriority1666;
		public virtual void setPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._setPriority1666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._setPriority1666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPriority1667;
		public virtual int getPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._getPriority1667);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getPriority1667);
		}
		internal static global::MonoJavaBridge.MethodId _create1668;
		public static global::android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._create1668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.IntentFilter;
		}
		internal static global::MonoJavaBridge.MethodId _match1669;
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._match1669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match1669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _match1670;
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._match1670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match1670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dump1671;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._dump1671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._dump1671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1672;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._writeToParcel1672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToParcel1672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1673;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._describeContents1673);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._describeContents1673);
		}
		internal static global::MonoJavaBridge.MethodId _getAction1674;
		public virtual global::java.lang.String getAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getAction1674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getAction1674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasCategory1675;
		public virtual bool hasCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasCategory1675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasCategory1675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCategory1676;
		public virtual void addCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addCategory1676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addCategory1676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAction1677;
		public virtual void addAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addAction1677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addAction1677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countActions1678;
		public virtual int countActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countActions1678);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countActions1678);
		}
		internal static global::MonoJavaBridge.MethodId _hasAction1679;
		public virtual bool hasAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasAction1679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasAction1679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchAction1680;
		public virtual bool matchAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._matchAction1680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchAction1680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _actionsIterator1681;
		public virtual global::java.util.Iterator actionsIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._actionsIterator1681)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._actionsIterator1681)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataType1682;
		public virtual void addDataType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataType1682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataType1682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasDataType1683;
		public virtual bool hasDataType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataType1683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataType1683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countDataTypes1684;
		public virtual int countDataTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataTypes1684);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataTypes1684);
		}
		internal static global::MonoJavaBridge.MethodId _getDataType1685;
		public virtual global::java.lang.String getDataType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataType1685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataType1685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _typesIterator1686;
		public virtual global::java.util.Iterator typesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._typesIterator1686)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._typesIterator1686)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataScheme1687;
		public virtual void addDataScheme(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataScheme1687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataScheme1687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countDataSchemes1688;
		public virtual int countDataSchemes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataSchemes1688);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataSchemes1688);
		}
		internal static global::MonoJavaBridge.MethodId _getDataScheme1689;
		public virtual global::java.lang.String getDataScheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataScheme1689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataScheme1689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataScheme1690;
		public virtual bool hasDataScheme(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataScheme1690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataScheme1690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _schemesIterator1691;
		public virtual global::java.util.Iterator schemesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._schemesIterator1691)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._schemesIterator1691)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataAuthority1692;
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataAuthority1692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataAuthority1692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDataAuthorities1693;
		public virtual int countDataAuthorities() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataAuthorities1693);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataAuthorities1693);
		}
		internal static global::MonoJavaBridge.MethodId _getDataAuthority1694;
		public virtual global::android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataAuthority1694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentFilter.AuthorityEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataAuthority1694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentFilter.AuthorityEntry;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataAuthority1695;
		public virtual bool hasDataAuthority(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataAuthority1695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataAuthority1695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _authoritiesIterator1696;
		public virtual global::java.util.Iterator authoritiesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._authoritiesIterator1696)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._authoritiesIterator1696)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _addDataPath1697;
		public virtual void addDataPath(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._addDataPath1697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataPath1697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDataPaths1698;
		public virtual int countDataPaths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countDataPaths1698);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataPaths1698);
		}
		internal static global::MonoJavaBridge.MethodId _getDataPath1699;
		public virtual global::android.os.PatternMatcher getDataPath(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getDataPath1699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.PatternMatcher;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataPath1699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.PatternMatcher;
		}
		internal static global::MonoJavaBridge.MethodId _hasDataPath1700;
		public virtual bool hasDataPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentFilter._hasDataPath1700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataPath1700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pathsIterator1701;
		public virtual global::java.util.Iterator pathsIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._pathsIterator1701)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._pathsIterator1701)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _matchDataAuthority1702;
		public virtual int matchDataAuthority(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._matchDataAuthority1702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchDataAuthority1702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchData1703;
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._matchData1703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchData1703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _countCategories1704;
		public virtual int countCategories() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentFilter._countCategories1704);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countCategories1704);
		}
		internal static global::MonoJavaBridge.MethodId _getCategory1705;
		public virtual global::java.lang.String getCategory(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._getCategory1705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getCategory1705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _categoriesIterator1706;
		public virtual global::java.util.Iterator categoriesIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._categoriesIterator1706)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._categoriesIterator1706)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _matchCategories1707;
		public virtual global::java.lang.String matchCategories(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentFilter._matchCategories1707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchCategories1707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToXml1708;
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._writeToXml1708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToXml1708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFromXml1709;
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentFilter._readFromXml1709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._readFromXml1709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter1710;
		public IntentFilter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1710);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter1711;
		public IntentFilter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter1712;
		public IntentFilter(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IntentFilter1713;
		public IntentFilter(android.content.IntentFilter arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR1714;
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
			global::android.content.IntentFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter"));
			global::android.content.IntentFilter._setPriority1666 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "setPriority", "(I)V");
			global::android.content.IntentFilter._getPriority1667 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getPriority", "()I");
			global::android.content.IntentFilter._create1668 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;");
			global::android.content.IntentFilter._match1669 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I");
			global::android.content.IntentFilter._match1670 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I");
			global::android.content.IntentFilter._dump1671 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.IntentFilter._writeToParcel1672 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.IntentFilter._describeContents1673 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "describeContents", "()I");
			global::android.content.IntentFilter._getAction1674 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._hasCategory1675 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._addCategory1676 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._addAction1677 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._countActions1678 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countActions", "()I");
			global::android.content.IntentFilter._hasAction1679 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._matchAction1680 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._actionsIterator1681 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataType1682 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._hasDataType1683 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._countDataTypes1684 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataTypes", "()I");
			global::android.content.IntentFilter._getDataType1685 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._typesIterator1686 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataScheme1687 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._countDataSchemes1688 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I");
			global::android.content.IntentFilter._getDataScheme1689 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._hasDataScheme1690 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._schemesIterator1691 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataAuthority1692 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.IntentFilter._countDataAuthorities1693 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I");
			global::android.content.IntentFilter._getDataAuthority1694 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;");
			global::android.content.IntentFilter._hasDataAuthority1695 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z");
			global::android.content.IntentFilter._authoritiesIterator1696 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataPath1697 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V");
			global::android.content.IntentFilter._countDataPaths1698 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countDataPaths", "()I");
			global::android.content.IntentFilter._getDataPath1699 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;");
			global::android.content.IntentFilter._hasDataPath1700 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._pathsIterator1701 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._matchDataAuthority1702 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I");
			global::android.content.IntentFilter._matchData1703 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I");
			global::android.content.IntentFilter._countCategories1704 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "countCategories", "()I");
			global::android.content.IntentFilter._getCategory1705 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._categoriesIterator1706 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._matchCategories1707 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;");
			global::android.content.IntentFilter._writeToXml1708 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V");
			global::android.content.IntentFilter._readFromXml1709 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::android.content.IntentFilter._IntentFilter1710 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "()V");
			global::android.content.IntentFilter._IntentFilter1711 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._IntentFilter1712 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.IntentFilter._IntentFilter1713 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V");
		}
	}
}
