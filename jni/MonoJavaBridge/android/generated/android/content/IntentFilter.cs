namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class IntentFilter : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static IntentFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.IntentFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.IntentFilter(@__env);
			}
		}
		protected IntentFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class AuthorityEntry : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static AuthorityEntry()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.IntentFilter.AuthorityEntry), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.IntentFilter.AuthorityEntry(@__env);
				}
			}
			internal AuthorityEntry(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPort1566;
			public int getPort() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.IntentFilter.AuthorityEntry._getPort1566);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getPort1566);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getHost1567;
			public global::java.lang.String getHost() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter.AuthorityEntry._getHost1567));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getHost1567));
			}
			internal static global::net.sf.jni4net.jni.MethodId _match1568;
			public int match(android.net.Uri arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.IntentFilter.AuthorityEntry._match1568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._match1568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _AuthorityEntry1569;
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1569, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__class;
				global::android.content.IntentFilter.AuthorityEntry._getPort1566 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I");
				global::android.content.IntentFilter.AuthorityEntry._getHost1567 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;");
				global::android.content.IntentFilter.AuthorityEntry._match1568 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I");
				global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1569 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class MalformedMimeTypeException : android.util.AndroidException
		{
			internal new static global::java.lang.Class staticClass;
			static MalformedMimeTypeException()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.IntentFilter.MalformedMimeTypeException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.IntentFilter.MalformedMimeTypeException(@__env);
				}
			}
			protected MalformedMimeTypeException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _MalformedMimeTypeException1570;
			public MalformedMimeTypeException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1570, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _MalformedMimeTypeException1571;
			public MalformedMimeTypeException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1571, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__class;
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1570 = @__env.GetMethodID(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V");
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1571 = @__env.GetMethodID(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPriority1572;
		public virtual void setPriority(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._setPriority1572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._setPriority1572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPriority1573;
		public virtual int getPriority() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._getPriority1573);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getPriority1573);
		}
		internal static global::net.sf.jni4net.jni.MethodId _create1574;
		public static global::android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallStaticObjectMethodPtr(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._create1574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _match1575;
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._match1575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match1575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _match1576;
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._match1576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match1576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump1577;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._dump1577, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._dump1577, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1578;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._writeToParcel1578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToParcel1578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1579;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._describeContents1579);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._describeContents1579);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAction1580;
		public virtual global::java.lang.String getAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getAction1580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getAction1580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasCategory1581;
		public virtual bool hasCategory(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasCategory1581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasCategory1581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addCategory1582;
		public virtual void addCategory(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addCategory1582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addCategory1582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAction1583;
		public virtual void addAction(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addAction1583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addAction1583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countActions1584;
		public virtual int countActions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countActions1584);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countActions1584);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAction1585;
		public virtual bool hasAction(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasAction1585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasAction1585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _matchAction1586;
		public virtual bool matchAction(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._matchAction1586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchAction1586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _actionsIterator1587;
		public virtual global::java.util.Iterator actionsIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._actionsIterator1587));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._actionsIterator1587));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addDataType1588;
		public virtual void addDataType(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataType1588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataType1588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasDataType1589;
		public virtual bool hasDataType(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataType1589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataType1589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countDataTypes1590;
		public virtual int countDataTypes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataTypes1590);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataTypes1590);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataType1591;
		public virtual global::java.lang.String getDataType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataType1591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataType1591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _typesIterator1592;
		public virtual global::java.util.Iterator typesIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._typesIterator1592));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._typesIterator1592));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addDataScheme1593;
		public virtual void addDataScheme(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataScheme1593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataScheme1593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countDataSchemes1594;
		public virtual int countDataSchemes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataSchemes1594);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataSchemes1594);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataScheme1595;
		public virtual global::java.lang.String getDataScheme(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataScheme1595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataScheme1595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasDataScheme1596;
		public virtual bool hasDataScheme(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataScheme1596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataScheme1596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _schemesIterator1597;
		public virtual global::java.util.Iterator schemesIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._schemesIterator1597));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._schemesIterator1597));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addDataAuthority1598;
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataAuthority1598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataAuthority1598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countDataAuthorities1599;
		public virtual int countDataAuthorities() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataAuthorities1599);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataAuthorities1599);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataAuthority1600;
		public virtual global::android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter.AuthorityEntry>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataAuthority1600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter.AuthorityEntry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataAuthority1600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasDataAuthority1601;
		public virtual bool hasDataAuthority(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataAuthority1601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataAuthority1601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _authoritiesIterator1602;
		public virtual global::java.util.Iterator authoritiesIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._authoritiesIterator1602));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._authoritiesIterator1602));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addDataPath1603;
		public virtual void addDataPath(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataPath1603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataPath1603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countDataPaths1604;
		public virtual int countDataPaths() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataPaths1604);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataPaths1604);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataPath1605;
		public virtual global::android.os.PatternMatcher getDataPath(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PatternMatcher>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataPath1605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PatternMatcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataPath1605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasDataPath1606;
		public virtual bool hasDataPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataPath1606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataPath1606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pathsIterator1607;
		public virtual global::java.util.Iterator pathsIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._pathsIterator1607));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._pathsIterator1607));
		}
		internal static global::net.sf.jni4net.jni.MethodId _matchDataAuthority1608;
		public virtual int matchDataAuthority(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._matchDataAuthority1608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchDataAuthority1608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _matchData1609;
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._matchData1609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchData1609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countCategories1610;
		public virtual int countCategories() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countCategories1610);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countCategories1610);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCategory1611;
		public virtual global::java.lang.String getCategory(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getCategory1611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getCategory1611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _categoriesIterator1612;
		public virtual global::java.util.Iterator categoriesIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._categoriesIterator1612));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._categoriesIterator1612));
		}
		internal static global::net.sf.jni4net.jni.MethodId _matchCategories1613;
		public virtual global::java.lang.String matchCategories(java.util.Set arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._matchCategories1613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchCategories1613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToXml1614;
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._writeToXml1614, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToXml1614, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromXml1615;
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._readFromXml1615, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._readFromXml1615, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1616;
		public IntentFilter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1616, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1617;
		public IntentFilter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1617, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1618;
		public IntentFilter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1618, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1619;
		public IntentFilter(android.content.IntentFilter arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1619, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1620;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.IntentFilter.staticClass = @__class;
			global::android.content.IntentFilter._setPriority1572 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "setPriority", "(I)V");
			global::android.content.IntentFilter._getPriority1573 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getPriority", "()I");
			global::android.content.IntentFilter._create1574 = @__env.GetStaticMethodID(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;");
			global::android.content.IntentFilter._match1575 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I");
			global::android.content.IntentFilter._match1576 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I");
			global::android.content.IntentFilter._dump1577 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.IntentFilter._writeToParcel1578 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.IntentFilter._describeContents1579 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "describeContents", "()I");
			global::android.content.IntentFilter._getAction1580 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._hasCategory1581 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._addCategory1582 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._addAction1583 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._countActions1584 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countActions", "()I");
			global::android.content.IntentFilter._hasAction1585 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._matchAction1586 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._actionsIterator1587 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataType1588 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._hasDataType1589 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._countDataTypes1590 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataTypes", "()I");
			global::android.content.IntentFilter._getDataType1591 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._typesIterator1592 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataScheme1593 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._countDataSchemes1594 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I");
			global::android.content.IntentFilter._getDataScheme1595 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._hasDataScheme1596 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._schemesIterator1597 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataAuthority1598 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.IntentFilter._countDataAuthorities1599 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I");
			global::android.content.IntentFilter._getDataAuthority1600 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;");
			global::android.content.IntentFilter._hasDataAuthority1601 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z");
			global::android.content.IntentFilter._authoritiesIterator1602 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._addDataPath1603 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V");
			global::android.content.IntentFilter._countDataPaths1604 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataPaths", "()I");
			global::android.content.IntentFilter._getDataPath1605 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;");
			global::android.content.IntentFilter._hasDataPath1606 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z");
			global::android.content.IntentFilter._pathsIterator1607 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._matchDataAuthority1608 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I");
			global::android.content.IntentFilter._matchData1609 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I");
			global::android.content.IntentFilter._countCategories1610 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countCategories", "()I");
			global::android.content.IntentFilter._getCategory1611 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;");
			global::android.content.IntentFilter._categoriesIterator1612 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;");
			global::android.content.IntentFilter._matchCategories1613 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;");
			global::android.content.IntentFilter._writeToXml1614 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V");
			global::android.content.IntentFilter._readFromXml1615 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::android.content.IntentFilter._IntentFilter1616 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "()V");
			global::android.content.IntentFilter._IntentFilter1617 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.IntentFilter._IntentFilter1618 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.IntentFilter._IntentFilter1619 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V");
		}
	}
}
