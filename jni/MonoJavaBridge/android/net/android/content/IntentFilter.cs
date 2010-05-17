namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class IntentFilter : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static IntentFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.IntentFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.IntentFilter.AuthorityEntry), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getPort1383; 
			public int getPort() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.IntentFilter.AuthorityEntry)) 
					return @__env.CallIntMethod(this, _getPort1383); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.AuthorityEntry.staticClass, _getPort1383); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getHost1384; 
			public java.lang.String getHost() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.IntentFilter.AuthorityEntry)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHost1384)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.AuthorityEntry.staticClass, _getHost1384)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _match1385; 
			public int match(android.net.Uri arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.IntentFilter.AuthorityEntry)) 
					return @__env.CallIntMethod(this, _match1385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.AuthorityEntry.staticClass, _match1385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AuthorityEntry1386; 
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, _AuthorityEntry1386, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__class; 
				global::android.content.IntentFilter.AuthorityEntry._getPort1383 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I"); 
				global::android.content.IntentFilter.AuthorityEntry._getHost1384 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;"); 
				global::android.content.IntentFilter.AuthorityEntry._match1385 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I"); 
				global::android.content.IntentFilter.AuthorityEntry._AuthorityEntry1386 = @__env.GetMethodID(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MalformedMimeTypeException : android.util.AndroidException
		{ 
			internal new static global::java.lang.Class staticClass; 
			static MalformedMimeTypeException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.IntentFilter.MalformedMimeTypeException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _MalformedMimeTypeException1387; 
			public MalformedMimeTypeException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, _MalformedMimeTypeException1387, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MalformedMimeTypeException1388; 
			public MalformedMimeTypeException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, _MalformedMimeTypeException1388, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__class; 
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1387 = @__env.GetMethodID(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V"); 
				global::android.content.IntentFilter.MalformedMimeTypeException._MalformedMimeTypeException1388 = @__env.GetMethodID(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPriority1389; 
		public virtual void setPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _setPriority1389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _setPriority1389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPriority1390; 
		public virtual int getPriority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _getPriority1390); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _getPriority1390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create1391; 
		public static android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallStaticObjectMethodPtr(android.content.IntentFilter.staticClass, _create1391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _match1392; 
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _match1392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _match1392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _match1393; 
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _match1393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _match1393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump1394; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _dump1394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _dump1394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1395; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _writeToParcel1395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _writeToParcel1395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1396; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _describeContents1396); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _describeContents1396); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction1397; 
		public virtual java.lang.String getAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAction1397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _getAction1397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasCategory1398; 
		public virtual bool hasCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _hasCategory1398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _hasCategory1398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addCategory1399; 
		public virtual void addCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _addCategory1399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _addCategory1399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addAction1400; 
		public virtual void addAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _addAction1400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _addAction1400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countActions1401; 
		public virtual int countActions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _countActions1401); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _countActions1401); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAction1402; 
		public virtual bool hasAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _hasAction1402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _hasAction1402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchAction1403; 
		public virtual bool matchAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _matchAction1403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _matchAction1403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _actionsIterator1404; 
		public virtual java.util.Iterator actionsIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _actionsIterator1404)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _actionsIterator1404)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataType1405; 
		public virtual void addDataType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _addDataType1405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _addDataType1405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataType1406; 
		public virtual bool hasDataType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _hasDataType1406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _hasDataType1406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataTypes1407; 
		public virtual int countDataTypes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _countDataTypes1407); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _countDataTypes1407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataType1408; 
		public virtual java.lang.String getDataType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDataType1408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _getDataType1408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _typesIterator1409; 
		public virtual java.util.Iterator typesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _typesIterator1409)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _typesIterator1409)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataScheme1410; 
		public virtual void addDataScheme(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _addDataScheme1410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _addDataScheme1410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataSchemes1411; 
		public virtual int countDataSchemes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _countDataSchemes1411); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _countDataSchemes1411); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataScheme1412; 
		public virtual java.lang.String getDataScheme(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDataScheme1412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _getDataScheme1412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataScheme1413; 
		public virtual bool hasDataScheme(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _hasDataScheme1413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _hasDataScheme1413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _schemesIterator1414; 
		public virtual java.util.Iterator schemesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _schemesIterator1414)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _schemesIterator1414)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataAuthority1415; 
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _addDataAuthority1415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _addDataAuthority1415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataAuthorities1416; 
		public virtual int countDataAuthorities() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _countDataAuthorities1416); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _countDataAuthorities1416); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataAuthority1417; 
		public virtual android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter.AuthorityEntry>(@__env, @__env.CallObjectMethodPtr(this, _getDataAuthority1417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter.AuthorityEntry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _getDataAuthority1417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataAuthority1418; 
		public virtual bool hasDataAuthority(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _hasDataAuthority1418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _hasDataAuthority1418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _authoritiesIterator1419; 
		public virtual java.util.Iterator authoritiesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _authoritiesIterator1419)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _authoritiesIterator1419)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addDataPath1420; 
		public virtual void addDataPath(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _addDataPath1420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _addDataPath1420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countDataPaths1421; 
		public virtual int countDataPaths() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _countDataPaths1421); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _countDataPaths1421); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataPath1422; 
		public virtual android.os.PatternMatcher getDataPath(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PatternMatcher>(@__env, @__env.CallObjectMethodPtr(this, _getDataPath1422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PatternMatcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _getDataPath1422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasDataPath1423; 
		public virtual bool hasDataPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallBooleanMethod(this, _hasDataPath1423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentFilter.staticClass, _hasDataPath1423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pathsIterator1424; 
		public virtual java.util.Iterator pathsIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _pathsIterator1424)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _pathsIterator1424)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchDataAuthority1425; 
		public virtual int matchDataAuthority(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _matchDataAuthority1425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _matchDataAuthority1425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchData1426; 
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _matchData1426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _matchData1426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countCategories1427; 
		public virtual int countCategories() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return @__env.CallIntMethod(this, _countCategories1427); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentFilter.staticClass, _countCategories1427); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCategory1428; 
		public virtual java.lang.String getCategory(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCategory1428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _getCategory1428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _categoriesIterator1429; 
		public virtual java.util.Iterator categoriesIterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _categoriesIterator1429)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _categoriesIterator1429)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _matchCategories1430; 
		public virtual java.lang.String matchCategories(java.util.Set arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _matchCategories1430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentFilter.staticClass, _matchCategories1430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToXml1431; 
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _writeToXml1431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _writeToXml1431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromXml1432; 
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentFilter)) 
				@__env.CallVoidMethod(this, _readFromXml1432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentFilter.staticClass, _readFromXml1432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1433; 
		public IntentFilter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, _IntentFilter1433, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1434; 
		public IntentFilter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, _IntentFilter1434, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1435; 
		public IntentFilter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, _IntentFilter1435, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _IntentFilter1436; 
		public IntentFilter(android.content.IntentFilter arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.IntentFilter.staticClass, _IntentFilter1436, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1437; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.IntentFilter.staticClass = @__class; 
			global::android.content.IntentFilter._setPriority1389 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "setPriority", "(I)V"); 
			global::android.content.IntentFilter._getPriority1390 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getPriority", "()I"); 
			global::android.content.IntentFilter._create1391 = @__env.GetStaticMethodID(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;"); 
			global::android.content.IntentFilter._match1392 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I"); 
			global::android.content.IntentFilter._match1393 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I"); 
			global::android.content.IntentFilter._dump1394 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._writeToParcel1395 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.IntentFilter._describeContents1396 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "describeContents", "()I"); 
			global::android.content.IntentFilter._getAction1397 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._hasCategory1398 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._addCategory1399 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._addAction1400 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._countActions1401 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countActions", "()I"); 
			global::android.content.IntentFilter._hasAction1402 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._matchAction1403 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._actionsIterator1404 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataType1405 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._hasDataType1406 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._countDataTypes1407 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataTypes", "()I"); 
			global::android.content.IntentFilter._getDataType1408 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._typesIterator1409 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataScheme1410 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._countDataSchemes1411 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I"); 
			global::android.content.IntentFilter._getDataScheme1412 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._hasDataScheme1413 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._schemesIterator1414 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataAuthority1415 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._countDataAuthorities1416 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I"); 
			global::android.content.IntentFilter._getDataAuthority1417 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;"); 
			global::android.content.IntentFilter._hasDataAuthority1418 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z"); 
			global::android.content.IntentFilter._authoritiesIterator1419 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._addDataPath1420 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V"); 
			global::android.content.IntentFilter._countDataPaths1421 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countDataPaths", "()I"); 
			global::android.content.IntentFilter._getDataPath1422 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;"); 
			global::android.content.IntentFilter._hasDataPath1423 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z"); 
			global::android.content.IntentFilter._pathsIterator1424 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._matchDataAuthority1425 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I"); 
			global::android.content.IntentFilter._matchData1426 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I"); 
			global::android.content.IntentFilter._countCategories1427 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "countCategories", "()I"); 
			global::android.content.IntentFilter._getCategory1428 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;"); 
			global::android.content.IntentFilter._categoriesIterator1429 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;"); 
			global::android.content.IntentFilter._matchCategories1430 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;"); 
			global::android.content.IntentFilter._writeToXml1431 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V"); 
			global::android.content.IntentFilter._readFromXml1432 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V"); 
			global::android.content.IntentFilter._IntentFilter1433 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "()V"); 
			global::android.content.IntentFilter._IntentFilter1434 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._IntentFilter1435 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.IntentFilter._IntentFilter1436 = @__env.GetMethodID(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V"); 
		} 
	} 
} 
