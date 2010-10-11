namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CursorJoiner : java.lang.Object, java.util.Iterator, java.lang.Iterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorJoiner()
		{
			InitJNI();
		}
		internal CursorJoiner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Result : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Result()
			{
				InitJNI();
			}
			internal Result(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values2601;
			public static global::android.database.CursorJoiner.Result[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.database.CursorJoiner.Result>(@__env.CallStaticObjectMethod(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._values2601)) as android.database.CursorJoiner.Result[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf2602;
			public static global::android.database.CursorJoiner.Result valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._valueOf2602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.CursorJoiner.Result;
			}
			internal static global::MonoJavaBridge.FieldId _BOTH2603;
			public static global::android.database.CursorJoiner.Result BOTH
			{
				get
				{
					return default(global::android.database.CursorJoiner.Result);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT2604;
			public static global::android.database.CursorJoiner.Result LEFT
			{
				get
				{
					return default(global::android.database.CursorJoiner.Result);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT2605;
			public static global::android.database.CursorJoiner.Result RIGHT
			{
				get
				{
					return default(global::android.database.CursorJoiner.Result);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.CursorJoiner.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorJoiner$Result"));
				global::android.database.CursorJoiner.Result._values2601 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "values", "()[Landroid/database/CursorJoiner/Result;");
				global::android.database.CursorJoiner.Result._valueOf2602 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _iterator2606;
		public global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorJoiner._iterator2606)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._iterator2606)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext2607;
		public bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorJoiner._hasNext2607);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._hasNext2607);
		}
		internal static global::MonoJavaBridge.MethodId _next2608;
		public global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorJoiner._next2608)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._next2608)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove2609;
		public void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorJoiner._remove2609);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._remove2609);
		}
		internal static global::MonoJavaBridge.MethodId _CursorJoiner2610;
		public CursorJoiner(android.database.Cursor arg0, java.lang.String[] arg1, android.database.Cursor arg2, java.lang.String[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._CursorJoiner2610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorJoiner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorJoiner"));
			global::android.database.CursorJoiner._iterator2606 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::android.database.CursorJoiner._hasNext2607 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "hasNext", "()Z");
			global::android.database.CursorJoiner._next2608 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "next", "()Ljava/lang/Object;");
			global::android.database.CursorJoiner._remove2609 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "remove", "()V");
			global::android.database.CursorJoiner._CursorJoiner2610 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang/String;)V");
		}
	}
}
