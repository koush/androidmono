namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Entity : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Entity()
		{
			InitJNI();
		}
		internal Entity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NamedContentValues : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static NamedContentValues()
			{
				InitJNI();
			}
			protected NamedContentValues(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _NamedContentValues3073;
			public NamedContentValues(android.net.Uri arg0, android.content.ContentValues arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Entity.NamedContentValues.staticClass, global::android.content.Entity.NamedContentValues._NamedContentValues3073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _uri3074;
			public global::android.net.Uri uri
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri3074)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _values3075;
			public global::android.content.ContentValues values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _values3075)) as android.content.ContentValues;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Entity.NamedContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Entity$NamedContentValues"));
				global::android.content.Entity.NamedContentValues._NamedContentValues3073 = @__env.GetMethodIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "<init>", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
				global::android.content.Entity.NamedContentValues._uri3074 = @__env.GetFieldIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "uri", "Landroid/net/Uri;");
				global::android.content.Entity.NamedContentValues._values3075 = @__env.GetFieldIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "values", "Landroid/content/ContentValues;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString3076;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Entity._toString3076)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._toString3076)) as java.lang.String;
		}
		public new global::android.content.ContentValues EntityValues
		{
			get
			{
				return getEntityValues();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntityValues3077;
		public global::android.content.ContentValues getEntityValues() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Entity._getEntityValues3077)) as android.content.ContentValues;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._getEntityValues3077)) as android.content.ContentValues;
		}
		public new global::java.util.ArrayList SubValues
		{
			get
			{
				return getSubValues();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubValues3078;
		public global::java.util.ArrayList getSubValues() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Entity._getSubValues3078)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._getSubValues3078)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addSubValue3079;
		public void addSubValue(android.net.Uri arg0, android.content.ContentValues arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Entity._addSubValue3079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._addSubValue3079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Entity3080;
		public Entity(android.content.ContentValues arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Entity.staticClass, global::android.content.Entity._Entity3080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Entity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Entity"));
			global::android.content.Entity._toString3076 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.Entity._getEntityValues3077 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "getEntityValues", "()Landroid/content/ContentValues;");
			global::android.content.Entity._getSubValues3078 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "getSubValues", "()Ljava/util/ArrayList;");
			global::android.content.Entity._addSubValue3079 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
			global::android.content.Entity._Entity3080 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
		}
	}
}
