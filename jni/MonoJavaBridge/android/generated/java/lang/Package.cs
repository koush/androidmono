namespace java.lang
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Package : java.lang.Object, java.lang.reflect.AnnotatedElement
	{
		internal static global::java.lang.Class staticClass;
		static Package()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.Package), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.lang.Package(@__env);
			}
		}
		protected Package(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12218;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._toString12218));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._toString12218));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12219;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Package._hashCode12219);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._hashCode12219);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName12220;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getName12220));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getName12220));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackage12221;
		public static global::java.lang.Package getPackage(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Package>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Package.staticClass, global::java.lang.Package._getPackage12221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnnotation12222;
		public virtual global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getAnnotation12222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.annotation.Annotation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotation12222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAnnotationPresent12223;
		public virtual bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isAnnotationPresent12223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isAnnotationPresent12223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAnnotations12224;
		public virtual global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getAnnotations12224));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getAnnotations12224));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaredAnnotations12225;
		public virtual global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getDeclaredAnnotations12225));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getDeclaredAnnotations12225));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackages12226;
		public static global::java.lang.Package[] getPackages() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Package.staticClass, global::java.lang.Package._getPackages12226));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSealed12227;
		public virtual bool isSealed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isSealed12227);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed12227);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSealed12228;
		public virtual bool isSealed(java.net.URL arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isSealed12228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isSealed12228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationTitle12229;
		public virtual global::java.lang.String getSpecificationTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getSpecificationTitle12229));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationTitle12229));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationVersion12230;
		public virtual global::java.lang.String getSpecificationVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getSpecificationVersion12230));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVersion12230));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationVendor12231;
		public virtual global::java.lang.String getSpecificationVendor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getSpecificationVendor12231));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getSpecificationVendor12231));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationTitle12232;
		public virtual global::java.lang.String getImplementationTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getImplementationTitle12232));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationTitle12232));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationVersion12233;
		public virtual global::java.lang.String getImplementationVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getImplementationVersion12233));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVersion12233));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationVendor12234;
		public virtual global::java.lang.String getImplementationVendor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Package._getImplementationVendor12234));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Package.staticClass, global::java.lang.Package._getImplementationVendor12234));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCompatibleWith12235;
		public virtual bool isCompatibleWith(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Package._isCompatibleWith12235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Package.staticClass, global::java.lang.Package._isCompatibleWith12235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.lang.Package.staticClass = @__class;
			global::java.lang.Package._toString12218 = @__env.GetMethodID(global::java.lang.Package.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Package._hashCode12219 = @__env.GetMethodID(global::java.lang.Package.staticClass, "hashCode", "()I");
			global::java.lang.Package._getName12220 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Package._getPackage12221 = @__env.GetStaticMethodID(global::java.lang.Package.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;");
			global::java.lang.Package._getAnnotation12222 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._isAnnotationPresent12223 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Package._getAnnotations12224 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getDeclaredAnnotations12225 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Package._getPackages12226 = @__env.GetStaticMethodID(global::java.lang.Package.staticClass, "getPackages", "()[Ljava/lang/Package;");
			global::java.lang.Package._isSealed12227 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isSealed", "()Z");
			global::java.lang.Package._isSealed12228 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isSealed", "(Ljava/net/URL;)Z");
			global::java.lang.Package._getSpecificationTitle12229 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVersion12230 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getSpecificationVendor12231 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationTitle12232 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationTitle", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVersion12233 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationVersion", "()Ljava/lang/String;");
			global::java.lang.Package._getImplementationVendor12234 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationVendor", "()Ljava/lang/String;");
			global::java.lang.Package._isCompatibleWith12235 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isCompatibleWith", "(Ljava/lang/String;)Z");
		}
	}
}
