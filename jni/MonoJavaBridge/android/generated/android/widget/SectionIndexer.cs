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
		internal static global::net.sf.jni4net.jni.MethodId _getSections11509;
		 global::java.lang.Object[] android.widget.SectionIndexer.getSections() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__SectionIndexer._getSections11509));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__SectionIndexer.staticClass, global::android.widget.__SectionIndexer._getSections11509));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionForSection11510;
		 int android.widget.SectionIndexer.getPositionForSection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__SectionIndexer._getPositionForSection11510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SectionIndexer.staticClass, global::android.widget.__SectionIndexer._getPositionForSection11510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSectionForPosition11511;
		 int android.widget.SectionIndexer.getSectionForPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__SectionIndexer._getSectionForPosition11511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__SectionIndexer.staticClass, global::android.widget.__SectionIndexer._getSectionForPosition11511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__SectionIndexer.staticClass = @__class;
			global::android.widget.__SectionIndexer._getSections11509 = @__env.GetMethodID(global::android.widget.__SectionIndexer.staticClass, "android.widget.SectionIndexer.getSections", "()[Ljava/lang/Object;");
			global::android.widget.__SectionIndexer._getPositionForSection11510 = @__env.GetMethodID(global::android.widget.__SectionIndexer.staticClass, "android.widget.SectionIndexer.getPositionForSection", "(I)I");
			global::android.widget.__SectionIndexer._getSectionForPosition11511 = @__env.GetMethodID(global::android.widget.__SectionIndexer.staticClass, "android.widget.SectionIndexer.getSectionForPosition", "(I)I");
		}
	}
}
