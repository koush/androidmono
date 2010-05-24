namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Filterable 
	{ 
		android.widget.Filter getFilter(); 
	} 

	public partial class Filterable_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Filterable.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Filterable : java.lang.Object, Filterable
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Filterable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.__Filterable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__Filterable(@__env); 
			} 
		} 
		internal __Filterable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10204; 
		 android.widget.Filter android.widget.Filterable.getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Filterable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter10204)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__Filterable.staticClass, _getFilter10204)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__Filterable.staticClass = @__class; 
			global::android.widget.__Filterable._getFilter10204 = @__env.GetMethodID(global::android.widget.__Filterable.staticClass, "android.widget.Filterable.getFilter", "()Landroid/widget/Filter;"); 
		} 
	} 
} 
