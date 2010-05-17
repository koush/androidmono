namespace java.lang 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Package : java.lang.Object, java.lang.reflect.AnnotatedElement
	{ 
		internal static global::java.lang.Class staticClass; 
		static Package() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.lang.Package), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode10666; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return @__env.CallIntMethod(this, _hashCode10666); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Package.staticClass, _hashCode10666); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10667; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10667)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _toString10667)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName10668; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName10668)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getName10668)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackage10669; 
		public static java.lang.Package getPackage(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Package>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Package.staticClass, _getPackage10669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnnotation10670; 
		public virtual java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.annotation.Annotation>(@__env, @__env.CallObjectMethodPtr(this, _getAnnotation10670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.annotation.Annotation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getAnnotation10670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAnnotationPresent10671; 
		public virtual bool isAnnotationPresent(java.lang.Class arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return @__env.CallBooleanMethod(this, _isAnnotationPresent10671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Package.staticClass, _isAnnotationPresent10671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAnnotations10672; 
		public virtual java.lang.annotation.Annotation[] getAnnotations() 
		{ 
			if (GetType() == typeof(java.lang.Package)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAnnotations10672)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getAnnotations10672)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaredAnnotations10673; 
		public virtual java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{ 
			if (GetType() == typeof(java.lang.Package)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getDeclaredAnnotations10673)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getDeclaredAnnotations10673)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackages10674; 
		public static java.lang.Package[] getPackages() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Package.staticClass, _getPackages10674)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSealed10675; 
		public virtual bool isSealed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return @__env.CallBooleanMethod(this, _isSealed10675); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Package.staticClass, _isSealed10675); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSealed10676; 
		public virtual bool isSealed(java.net.URL arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return @__env.CallBooleanMethod(this, _isSealed10676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Package.staticClass, _isSealed10676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCompatibleWith10677; 
		public virtual bool isCompatibleWith(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return @__env.CallBooleanMethod(this, _isCompatibleWith10677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Package.staticClass, _isCompatibleWith10677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationTitle10678; 
		public virtual java.lang.String getSpecificationTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSpecificationTitle10678)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getSpecificationTitle10678)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationVersion10679; 
		public virtual java.lang.String getSpecificationVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSpecificationVersion10679)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getSpecificationVersion10679)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpecificationVendor10680; 
		public virtual java.lang.String getSpecificationVendor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSpecificationVendor10680)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getSpecificationVendor10680)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationTitle10681; 
		public virtual java.lang.String getImplementationTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getImplementationTitle10681)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getImplementationTitle10681)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationVersion10682; 
		public virtual java.lang.String getImplementationVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getImplementationVersion10682)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getImplementationVersion10682)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImplementationVendor10683; 
		public virtual java.lang.String getImplementationVendor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Package)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getImplementationVendor10683)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Package.staticClass, _getImplementationVendor10683)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.lang.Package.staticClass = @__class; 
			global::java.lang.Package._hashCode10666 = @__env.GetMethodID(global::java.lang.Package.staticClass, "hashCode", "()I"); 
			global::java.lang.Package._toString10667 = @__env.GetMethodID(global::java.lang.Package.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.lang.Package._getName10668 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.lang.Package._getPackage10669 = @__env.GetStaticMethodID(global::java.lang.Package.staticClass, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;"); 
			global::java.lang.Package._getAnnotation10670 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"); 
			global::java.lang.Package._isAnnotationPresent10671 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z"); 
			global::java.lang.Package._getAnnotations10672 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;"); 
			global::java.lang.Package._getDeclaredAnnotations10673 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"); 
			global::java.lang.Package._getPackages10674 = @__env.GetStaticMethodID(global::java.lang.Package.staticClass, "getPackages", "()[Ljava/lang/Package;"); 
			global::java.lang.Package._isSealed10675 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isSealed", "()Z"); 
			global::java.lang.Package._isSealed10676 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isSealed", "(Ljava/net/URL;)Z"); 
			global::java.lang.Package._isCompatibleWith10677 = @__env.GetMethodID(global::java.lang.Package.staticClass, "isCompatibleWith", "(Ljava/lang/String;)Z"); 
			global::java.lang.Package._getSpecificationTitle10678 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationTitle", "()Ljava/lang/String;"); 
			global::java.lang.Package._getSpecificationVersion10679 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationVersion", "()Ljava/lang/String;"); 
			global::java.lang.Package._getSpecificationVendor10680 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getSpecificationVendor", "()Ljava/lang/String;"); 
			global::java.lang.Package._getImplementationTitle10681 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationTitle", "()Ljava/lang/String;"); 
			global::java.lang.Package._getImplementationVersion10682 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationVersion", "()Ljava/lang/String;"); 
			global::java.lang.Package._getImplementationVendor10683 = @__env.GetMethodID(global::java.lang.Package.staticClass, "getImplementationVendor", "()Ljava/lang/String;"); 
		} 
	} 
} 
