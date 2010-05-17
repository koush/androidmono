namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CursorJoiner : java.lang.Object, java.util.Iterator, java.lang.Iterable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CursorJoiner() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.CursorJoiner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.CursorJoiner(@__env); 
			} 
		} 
		internal CursorJoiner(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Result : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Result() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.CursorJoiner.Result), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.database.CursorJoiner.Result(@__env); 
				} 
			} 
			internal Result(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2070; 
			public static android.database.CursorJoiner.Result valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorJoiner.Result>(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorJoiner.Result.staticClass, _valueOf2070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2071; 
			public static android.database.CursorJoiner.Result[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorJoiner.Result.staticClass, _values2071)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BOTH2072; 
			public static android.database.CursorJoiner.Result BOTH
			{ 
				get 
				{ 
					return default(android.database.CursorJoiner.Result); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LEFT2073; 
			public static android.database.CursorJoiner.Result LEFT
			{ 
				get 
				{ 
					return default(android.database.CursorJoiner.Result); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT2074; 
			public static android.database.CursorJoiner.Result RIGHT
			{ 
				get 
				{ 
					return default(android.database.CursorJoiner.Result); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.database.CursorJoiner.Result.staticClass = @__class; 
				global::android.database.CursorJoiner.Result._valueOf2070 = @__env.GetStaticMethodID(global::android.database.CursorJoiner.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;"); 
				global::android.database.CursorJoiner.Result._values2071 = @__env.GetStaticMethodID(global::android.database.CursorJoiner.Result.staticClass, "values", "()[Landroid/database/CursorJoiner/Result;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _iterator2075; 
		public java.util.Iterator iterator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorJoiner)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, _iterator2075)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorJoiner.staticClass, _iterator2075)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasNext2076; 
		public bool hasNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorJoiner)) 
				return @__env.CallBooleanMethod(this, _hasNext2076); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorJoiner.staticClass, _hasNext2076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next2077; 
		public java.lang.Object next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorJoiner)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _next2077)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorJoiner.staticClass, _next2077)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove2078; 
		public void remove() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorJoiner)) 
				@__env.CallVoidMethod(this, _remove2078); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorJoiner.staticClass, _remove2078); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorJoiner2079; 
		public CursorJoiner(android.database.Cursor arg0, java.lang.String[] arg1, android.database.Cursor arg2, java.lang.String[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorJoiner.staticClass, _CursorJoiner2079, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.CursorJoiner.staticClass = @__class; 
			global::android.database.CursorJoiner._iterator2075 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "iterator", "()Ljava/util/Iterator;"); 
			global::android.database.CursorJoiner._hasNext2076 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "hasNext", "()Z"); 
			global::android.database.CursorJoiner._next2077 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "next", "()Ljava/lang/Object;"); 
			global::android.database.CursorJoiner._remove2078 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "remove", "()V"); 
			global::android.database.CursorJoiner._CursorJoiner2079 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang/String;)V"); 
		} 
	} 
} 
