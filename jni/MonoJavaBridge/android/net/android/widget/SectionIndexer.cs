namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SectionIndexer 
	{ 
		global::java.lang.Object[] getSections(); 
		int getPositionForSection(int arg0); 
		int getSectionForPosition(int arg0); 
	} 

	public partial class SectionIndexer_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SectionIndexer.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SectionIndexer : java.lang.Object, SectionIndexer
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SectionIndexer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__SectionIndexer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__SectionIndexer(@__env); 
			} 
		} 
		internal __SectionIndexer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSections10796; 
		 global::java.lang.Object[] android.widget.SectionIndexer.getSections() 
		{ 
			if (GetType() == typeof(android.widget.__SectionIndexer)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__SectionIndexer._getSections10796)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__SectionIndexer.staticClass, global::android.widget.__SectionIndexer._getSections10796)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionForSection10797; 
		 int android.widget.SectionIndexer.getPositionForSection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SectionIndexer)) 
				return @__env.CallIntMethod(this, global::android.widget.__SectionIndexer._getPositionForSection10797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SectionIndexer.staticClass, global::android.widget.__SectionIndexer._getPositionForSection10797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSectionForPosition10798; 
		 int android.widget.SectionIndexer.getSectionForPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SectionIndexer)) 
				return @__env.CallIntMethod(this, global::android.widget.__SectionIndexer._getSectionForPosition10798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SectionIndexer.staticClass, global::android.widget.__SectionIndexer._getSectionForPosition10798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__SectionIndexer.staticClass = @__class; 
			global::android.widget.__SectionIndexer._getSections10796 = @__env.GetMethodID(global::android.widget.__SectionIndexer.staticClass, "android.widget.SectionIndexer.getSections", "()[Ljava/lang/Object;"); 
			global::android.widget.__SectionIndexer._getPositionForSection10797 = @__env.GetMethodID(global::android.widget.__SectionIndexer.staticClass, "android.widget.SectionIndexer.getPositionForSection", "(I)I"); 
			global::android.widget.__SectionIndexer._getSectionForPosition10798 = @__env.GetMethodID(global::android.widget.__SectionIndexer.staticClass, "android.widget.SectionIndexer.getSectionForPosition", "(I)I"); 
		} 
	} 
} 
