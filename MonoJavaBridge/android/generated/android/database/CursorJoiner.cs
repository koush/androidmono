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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.database.CursorJoiner.Result[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.CursorJoiner.Result._m0.native == global::System.IntPtr.Zero)
					global::android.database.CursorJoiner.Result._m0 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "values", "()[Landroid/database/CursorJoiner/Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.database.CursorJoiner.Result>(@__env.CallStaticObjectMethod(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._m0)) as android.database.CursorJoiner.Result[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.database.CursorJoiner.Result valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.CursorJoiner.Result._m1.native == global::System.IntPtr.Zero)
					global::android.database.CursorJoiner.Result._m1 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.CallStaticObjectMethod(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.CursorJoiner.Result;
			}
			internal static global::MonoJavaBridge.FieldId _BOTH2196;
			public static global::android.database.CursorJoiner.Result BOTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.GetStaticObjectField(global::android.database.CursorJoiner.Result.staticClass, _BOTH2196)) as android.database.CursorJoiner.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT2197;
			public static global::android.database.CursorJoiner.Result LEFT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.GetStaticObjectField(global::android.database.CursorJoiner.Result.staticClass, _LEFT2197)) as android.database.CursorJoiner.Result;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT2198;
			public static global::android.database.CursorJoiner.Result RIGHT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.database.CursorJoiner.Result>(@__env.GetStaticObjectField(global::android.database.CursorJoiner.Result.staticClass, _RIGHT2198)) as android.database.CursorJoiner.Result;
				}
			}
			static Result()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.CursorJoiner.Result.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorJoiner$Result"));
				global::android.database.CursorJoiner.Result._BOTH2196 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "BOTH", "Landroid/database/CursorJoiner$Result;");
				global::android.database.CursorJoiner.Result._LEFT2197 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "LEFT", "Landroid/database/CursorJoiner$Result;");
				global::android.database.CursorJoiner.Result._RIGHT2198 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorJoiner.Result.staticClass, "RIGHT", "Landroid/database/CursorJoiner$Result;");
			}
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.database.CursorJoiner.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::android.database.CursorJoiner._m0) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorJoiner.staticClass, "hasNext", "()Z", ref global::android.database.CursorJoiner._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.CursorJoiner.staticClass, "next", "()Ljava/lang/Object;", ref global::android.database.CursorJoiner._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorJoiner.staticClass, "remove", "()V", ref global::android.database.CursorJoiner._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public CursorJoiner(android.database.Cursor arg0, java.lang.String[] arg1, android.database.Cursor arg2, java.lang.String[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorJoiner._m4.native == global::System.IntPtr.Zero)
				global::android.database.CursorJoiner._m4 = @__env.GetMethodIDNoThrow(global::android.database.CursorJoiner.staticClass, "<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static CursorJoiner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorJoiner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorJoiner"));
		}
	}
}
