namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Entity : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Entity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NamedContentValues : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected NamedContentValues(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public NamedContentValues(android.net.Uri arg0, android.content.ContentValues arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.Entity.NamedContentValues._m0.native == global::System.IntPtr.Zero)
					global::android.content.Entity.NamedContentValues._m0 = @__env.GetMethodIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "<init>", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Entity.NamedContentValues.staticClass, global::android.content.Entity.NamedContentValues._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _uri1681;
			public global::android.net.Uri uri
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri1681)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _values1682;
			public global::android.content.ContentValues values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ContentValues>(@__env.GetObjectField(this.JvmHandle, _values1682)) as android.content.ContentValues;
				}
			}
			static NamedContentValues()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Entity.NamedContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Entity$NamedContentValues"));
				global::android.content.Entity.NamedContentValues._uri1681 = @__env.GetFieldIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "uri", "Landroid/net/Uri;");
				global::android.content.Entity.NamedContentValues._values1682 = @__env.GetFieldIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "values", "Landroid/content/ContentValues;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Entity.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.Entity._m0) as java.lang.String;
		}
		public new global::android.content.ContentValues EntityValues
		{
			get
			{
				return getEntityValues();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::android.content.ContentValues getEntityValues()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ContentValues>(this, global::android.content.Entity.staticClass, "getEntityValues", "()Landroid/content/ContentValues;", ref global::android.content.Entity._m1) as android.content.ContentValues;
		}
		public new global::java.util.ArrayList SubValues
		{
			get
			{
				return getSubValues();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.util.ArrayList getSubValues()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Entity.staticClass, "getSubValues", "()Ljava/util/ArrayList;", ref global::android.content.Entity._m2) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void addSubValue(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Entity.staticClass, "addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V", ref global::android.content.Entity._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public Entity(android.content.ContentValues arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Entity._m4.native == global::System.IntPtr.Zero)
				global::android.content.Entity._m4 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Entity.staticClass, global::android.content.Entity._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Entity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Entity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Entity"));
		}
	}
}
