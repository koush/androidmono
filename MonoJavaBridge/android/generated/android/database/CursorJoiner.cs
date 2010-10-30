namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CursorJoiner : java.lang.Object, java.util.Iterator, java.lang.Iterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CursorJoiner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Result : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Result(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values4516;
			public static global::android.database.CursorJoiner.Result[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.CursorJoiner.Result._values4516.native == global::System.IntPtr.Zero)
					global::android.database.CursorJoiner.Result._values4516 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "values", "()[Landroid/database/CursorJoiner/Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.database.CursorJoiner.Result>(@__env.CallStaticObjectMethod(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._values4516)) as android.database.CursorJoiner.Result[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf4517;
			public static global::android.database.CursorJoiner.Result valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.CursorJoiner.Result._valueOf4517.native == global::System.IntPtr.Zero)
					global::android.database.CursorJoiner.Result._valueOf4517 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.CallStaticObjectMethod(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._valueOf4517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.CursorJoiner.Result;
			}
			internal static global::MonoJavaBridge.FieldId _BOTH4518;
			public static global::android.database.CursorJoiner.Result BOTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.GetStaticObjectField(global::android.database.CursorJoiner.Result.staticClass, _BOTH4518)) as android.database.CursorJoiner.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT4519;
			public static global::android.database.CursorJoiner.Result LEFT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.GetStaticObjectField(global::android.database.CursorJoiner.Result.staticClass, _LEFT4519)) as android.database.CursorJoiner.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT4520;
			public static global::android.database.CursorJoiner.Result RIGHT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.GetStaticObjectField(global::android.database.CursorJoiner.Result.staticClass, _RIGHT4520)) as android.database.CursorJoiner.Result;
				}
			}
			static Result()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.CursorJoiner.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorJoiner$Result"));
				global::android.database.CursorJoiner.Result._BOTH4518 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "BOTH", "Landroid/database/CursorJoiner$Result;");
				global::android.database.CursorJoiner.Result._LEFT4519 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "LEFT", "Landroid/database/CursorJoiner$Result;");
				global::android.database.CursorJoiner.Result._RIGHT4520 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "RIGHT", "Landroid/database/CursorJoiner$Result;");
			}
			internal static void InitJNI()
			{
			}
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator4521;
		public global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.database.CursorJoiner.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::android.database.CursorJoiner._iterator4521) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext4522;
		public bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorJoiner.staticClass, "hasNext", "()Z", ref global::android.database.CursorJoiner._hasNext4522);
		}
		internal static global::MonoJavaBridge.MethodId _next4523;
		public global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.CursorJoiner.staticClass, "next", "()Ljava/lang/Object;", ref global::android.database.CursorJoiner._next4523) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove4524;
		public void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorJoiner.staticClass, "remove", "()V", ref global::android.database.CursorJoiner._remove4524);
		}
		internal static global::MonoJavaBridge.MethodId _CursorJoiner4525;
		public CursorJoiner(android.database.Cursor arg0, java.lang.String[] arg1, android.database.Cursor arg2, java.lang.String[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorJoiner._CursorJoiner4525.native == global::System.IntPtr.Zero)
				global::android.database.CursorJoiner._CursorJoiner4525 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._CursorJoiner4525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static CursorJoiner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorJoiner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorJoiner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
