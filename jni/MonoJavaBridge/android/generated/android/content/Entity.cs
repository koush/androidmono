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
			internal static global::MonoJavaBridge.MethodId _NamedContentValues1517;
			public NamedContentValues(android.net.Uri arg0, android.content.ContentValues arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Entity.NamedContentValues.staticClass, global::android.content.Entity.NamedContentValues._NamedContentValues1517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _uri1518;
			public global::android.net.Uri uri
			{
				get
				{
					return default(global::android.net.Uri);
				}
			}
			internal static global::MonoJavaBridge.FieldId _values1519;
			public global::android.content.ContentValues values
			{
				get
				{
					return default(global::android.content.ContentValues);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Entity.NamedContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Entity$NamedContentValues"));
				global::android.content.Entity.NamedContentValues._NamedContentValues1517 = @__env.GetMethodIDNoThrow(global::android.content.Entity.NamedContentValues.staticClass, "<init>", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString1520;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Entity._toString1520)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._toString1520)) as java.lang.String;
		}
		public new global::android.content.ContentValues EntityValues
		{
			get
			{
				return getEntityValues();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntityValues1521;
		public global::android.content.ContentValues getEntityValues() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Entity._getEntityValues1521)) as android.content.ContentValues;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._getEntityValues1521)) as android.content.ContentValues;
		}
		public new global::java.util.ArrayList SubValues
		{
			get
			{
				return getSubValues();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubValues1522;
		public global::java.util.ArrayList getSubValues() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Entity._getSubValues1522)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._getSubValues1522)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addSubValue1523;
		public void addSubValue(android.net.Uri arg0, android.content.ContentValues arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Entity._addSubValue1523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Entity.staticClass, global::android.content.Entity._addSubValue1523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Entity1524;
		public Entity(android.content.ContentValues arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Entity.staticClass, global::android.content.Entity._Entity1524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Entity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Entity"));
			global::android.content.Entity._toString1520 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.Entity._getEntityValues1521 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "getEntityValues", "()Landroid/content/ContentValues;");
			global::android.content.Entity._getSubValues1522 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "getSubValues", "()Ljava/util/ArrayList;");
			global::android.content.Entity._addSubValue1523 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
			global::android.content.Entity._Entity1524 = @__env.GetMethodIDNoThrow(global::android.content.Entity.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
		}
	}
}
