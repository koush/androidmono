namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Entity : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Entity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.Entity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.Entity(@__env);
			}
		}
		internal Entity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class NamedContentValues : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static NamedContentValues()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.Entity.NamedContentValues), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.Entity.NamedContentValues(@__env);
				}
			}
			protected NamedContentValues(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _NamedContentValues1423;
			public NamedContentValues(android.net.Uri arg0, android.content.ContentValues arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.Entity.NamedContentValues.staticClass, global::android.content.Entity.NamedContentValues._NamedContentValues1423, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.FieldId _uri1424;
			public global::android.net.Uri uri
			{
				get
				{
					return default(global::android.net.Uri);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _values1425;
			public global::android.content.ContentValues values
			{
				get
				{
					return default(global::android.content.ContentValues);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.Entity.NamedContentValues.staticClass = @__class;
				global::android.content.Entity.NamedContentValues._NamedContentValues1423 = @__env.GetMethodID(global::android.content.Entity.NamedContentValues.staticClass, "<init>", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1426;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Entity._toString1426));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Entity.staticClass, global::android.content.Entity._toString1426));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntityValues1427;
		public global::android.content.ContentValues getEntityValues() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Entity._getEntityValues1427));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Entity.staticClass, global::android.content.Entity._getEntityValues1427));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubValues1428;
		public global::java.util.ArrayList getSubValues() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Entity._getSubValues1428));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Entity.staticClass, global::android.content.Entity._getSubValues1428));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSubValue1429;
		public void addSubValue(android.net.Uri arg0, android.content.ContentValues arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.Entity._addSubValue1429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.Entity.staticClass, global::android.content.Entity._addSubValue1429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Entity1430;
		public Entity(android.content.ContentValues arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.Entity.staticClass, global::android.content.Entity._Entity1430, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.Entity.staticClass = @__class;
			global::android.content.Entity._toString1426 = @__env.GetMethodID(global::android.content.Entity.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.Entity._getEntityValues1427 = @__env.GetMethodID(global::android.content.Entity.staticClass, "getEntityValues", "()Landroid/content/ContentValues;");
			global::android.content.Entity._getSubValues1428 = @__env.GetMethodID(global::android.content.Entity.staticClass, "getSubValues", "()Ljava/util/ArrayList;");
			global::android.content.Entity._addSubValue1429 = @__env.GetMethodID(global::android.content.Entity.staticClass, "addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V");
			global::android.content.Entity._Entity1430 = @__env.GetMethodID(global::android.content.Entity.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
		}
	}
}
