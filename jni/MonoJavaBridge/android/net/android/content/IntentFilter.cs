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
			internal static global::net.sf.jni4net.jni.MethodId _getPort1405; 
			public int getPort() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.content.IntentFilter.AuthorityEntry._getPort1405); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getPort1405); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getHost1406; 
			public global::java.lang.String getHost() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter.AuthorityEntry._getHost1406)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._getHost1406)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _match1407; 
			public int match(android.net.Uri arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.content.IntentFilter.AuthorityEntry._match1407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._match1407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AuthorityEntry1408; 
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1408, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__class; 
				global::android.content.IntentFilter.AuthorityEntry._getPort1405 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I"); 
				global::android.content.IntentFilter.AuthorityEntry._getHost1406 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;"); 
				global::android.content.IntentFilter.AuthorityEntry._match1407 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I"); 
				global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1408 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _MalformedMimeTypeException1409; 
			public MalformedMimeTypeException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1409, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MalformedMimeTypeException1410; 
			public MalformedMimeTypeException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1410, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__class; 
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1409 = @__env.GetMethodID(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V"); 
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1410 = @__env.GetMethodID(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPriority1411; 
		public virtual void setPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._setPriority1411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._setPriority1411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPriority1412; 
		public virtual int getPriority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._getPriority1412); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getPriority1412); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create1413; 
		public static global::android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallStaticObjectMethodPtr(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._create1413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _match1414; 
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._match1414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match1414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _match1415; 
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._match1415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._match1415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump1416; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._dump1416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._dump1416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1417; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._writeToParcel1417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToParcel1417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1418; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._describeContents1418); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._describeContents1418); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction1419; 
		public virtual global::java.lang.String getAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getAction1419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getAction1419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasCategory1420; 
		public virtual bool hasCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasCategory1420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasCategory1420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addCategory1421; 
		public virtual void addCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addCategory1421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addCategory1421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAction1422; 
		public virtual void addAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addAction1422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addAction1422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countActions1423; 
		public virtual int countActions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countActions1423); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countActions1423); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAction1424; 
		public virtual bool hasAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasAction1424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasAction1424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchAction1425; 
		public virtual bool matchAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._matchAction1425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchAction1425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _actionsIterator1426; 
		public virtual global::java.util.Iterator actionsIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._actionsIterator1426)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._actionsIterator1426)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataType1427; 
		public virtual void addDataType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataType1427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataType1427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataType1428; 
		public virtual bool hasDataType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataType1428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataType1428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataTypes1429; 
		public virtual int countDataTypes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataTypes1429); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataTypes1429); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataType1430; 
		public virtual global::java.lang.String getDataType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataType1430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataType1430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _typesIterator1431; 
		public virtual global::java.util.Iterator typesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._typesIterator1431)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._typesIterator1431)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataScheme1432; 
		public virtual void addDataScheme(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataScheme1432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataScheme1432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataSchemes1433; 
		public virtual int countDataSchemes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataSchemes1433); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataSchemes1433); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataScheme1434; 
		public virtual global::java.lang.String getDataScheme(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataScheme1434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataScheme1434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataScheme1435; 
		public virtual bool hasDataScheme(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataScheme1435, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataScheme1435, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _schemesIterator1436; 
		public virtual global::java.util.Iterator schemesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._schemesIterator1436)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._schemesIterator1436)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataAuthority1437; 
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataAuthority1437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataAuthority1437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataAuthorities1438; 
		public virtual int countDataAuthorities() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataAuthorities1438); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataAuthorities1438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataAuthority1439; 
		public virtual global::android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter.AuthorityEntry>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataAuthority1439, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter.AuthorityEntry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataAuthority1439, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataAuthority1440; 
		public virtual bool hasDataAuthority(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataAuthority1440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataAuthority1440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _authoritiesIterator1441; 
		public virtual global::java.util.Iterator authoritiesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._authoritiesIterator1441)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._authoritiesIterator1441)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataPath1442; 
		public virtual void addDataPath(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._addDataPath1442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._addDataPath1442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataPaths1443; 
		public virtual int countDataPaths() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countDataPaths1443); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countDataPaths1443); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataPath1444; 
		public virtual global::android.os.PatternMatcher getDataPath(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PatternMatcher>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getDataPath1444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PatternMatcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getDataPath1444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataPath1445; 
		public virtual bool hasDataPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.IntentFilter._hasDataPath1445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._hasDataPath1445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pathsIterator1446; 
		public virtual global::java.util.Iterator pathsIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._pathsIterator1446)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._pathsIterator1446)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchDataAuthority1447; 
		public virtual int matchDataAuthority(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._matchDataAuthority1447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchDataAuthority1447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchData1448; 
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._matchData1448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchData1448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countCategories1449; 
		public virtual int countCategories() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.content.IntentFilter._countCategories1449); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._countCategories1449); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCategory1450; 
		public virtual global::java.lang.String getCategory(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._getCategory1450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._getCategory1450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _categoriesIterator1451; 
		public virtual global::java.util.Iterator categoriesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._categoriesIterator1451)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._categoriesIterator1451)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchCategories1452; 
		public virtual global::java.lang.String matchCategories(java.util.Set arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentFilter._matchCategories1452, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._matchCategories1452, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToXml1453; 
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._writeToXml1453, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._writeToXml1453, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromXml1454; 
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.content.IntentFilter._readFromXml1454, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentFilter.staticClass, global::android.content.IntentFilter._readFromXml1454, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1455; 
		public IntentFilter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1455, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1456; 
		public IntentFilter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1456, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1457; 
		public IntentFilter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1457, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1458; 
		public IntentFilter(android.content.IntentFilter arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._IntentFilter1458, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1459; 
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
			global::android.content.IntentFilter._setPriority1411 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "setPriority", "(I)V"); 
			global::android.content.IntentFilter._getPriority1412 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getPriority", "()I"); 
			global::android.content.IntentFilter._create1413 = @__env.GetStaticMethodID(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;"); 
			global::android.content.IntentFilter._match1414 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I"); 
			global::android.content.IntentFilter._match1415 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I"); 
			global::android.content.IntentFilter._dump1416 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._writeToParcel1417 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.IntentFilter._describeContents1418 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "describeContents", "()I"); 
			global::android.content.IntentFilter._getAction1419 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._hasCategory1420 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._addCategory1421 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._addAction1422 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._countActions1423 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countActions", "()I"); 
			global::android.content.IntentFilter._hasAction1424 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._matchAction1425 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._actionsIterator1426 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataType1427 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._hasDataType1428 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._countDataTypes1429 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataTypes", "()I"); 
			global::android.content.IntentFilter._getDataType1430 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._typesIterator1431 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataScheme1432 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._countDataSchemes1433 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I"); 
			global::android.content.IntentFilter._getDataScheme1434 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._hasDataScheme1435 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._schemesIterator1436 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataAuthority1437 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._countDataAuthorities1438 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I"); 
			global::android.content.IntentFilter._getDataAuthority1439 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;"); 
			global::android.content.IntentFilter._hasDataAuthority1440 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z"); 
			global::android.content.IntentFilter._authoritiesIterator1441 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataPath1442 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V"); 
			global::android.content.IntentFilter._countDataPaths1443 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataPaths", "()I"); 
			global::android.content.IntentFilter._getDataPath1444 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;"); 
			global::android.content.IntentFilter._hasDataPath1445 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._pathsIterator1446 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._matchDataAuthority1447 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I"); 
			global::android.content.IntentFilter._matchData1448 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I"); 
			global::android.content.IntentFilter._countCategories1449 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countCategories", "()I"); 
			global::android.content.IntentFilter._getCategory1450 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._categoriesIterator1451 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._matchCategories1452 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;"); 
			global::android.content.IntentFilter._writeToXml1453 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V"); 
			global::android.content.IntentFilter._readFromXml1454 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V"); 
			global::android.content.IntentFilter._IntentFilter1455 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "()V"); 
			global::android.content.IntentFilter._IntentFilter1456 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._IntentFilter1457 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._IntentFilter1458 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V"); 
		} 
	} 
} 
