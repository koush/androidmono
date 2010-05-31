namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Filter : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Filter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Filter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Filter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface FilterListener 
		{
			void onFilterComplete(int arg0);
		}

		public partial class FilterListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __FilterListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __FilterListener : java.lang.Object, FilterListener
		{
			internal static global::java.lang.Class staticClass;
			static __FilterListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Filter.__FilterListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.Filter.__FilterListener(@__env);
				}
			}
			internal __FilterListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete10193;
			 void android.widget.Filter.FilterListener.onFilterComplete(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.Filter.__FilterListener._onFilterComplete10193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.Filter.__FilterListener.staticClass, global::android.widget.Filter.__FilterListener._onFilterComplete10193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.Filter.__FilterListener.staticClass = @__class;
				global::android.widget.Filter.__FilterListener._onFilterComplete10193 = @__env.GetMethodID(global::android.widget.Filter.__FilterListener.staticClass, "android.widget.Filter.FilterListener.onFilterComplete", "(I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		protected class FilterResults : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static FilterResults()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Filter.FilterResults), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.Filter.FilterResults(@__env);
				}
			}
			protected FilterResults(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _FilterResults10194;
			public FilterResults()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.Filter.FilterResults.staticClass, global::android.widget.Filter.FilterResults._FilterResults10194, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _values10195;
			public global::java.lang.Object values
			{
				get
				{
					return default(global::java.lang.Object);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _count10196;
			public int count
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.Filter.FilterResults.staticClass = @__class;
				global::android.widget.Filter.FilterResults._FilterResults10194 = @__env.GetMethodID(global::android.widget.Filter.FilterResults.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _filter10197;
		public virtual void filter(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Filter._filter10197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Filter.staticClass, global::android.widget.Filter._filter10197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _filter10198;
		public virtual void filter(java.lang.CharSequence arg0, android.widget.Filter.FilterListener arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Filter._filter10198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Filter.staticClass, global::android.widget.Filter._filter10198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performFiltering10199;
		protected abstract global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0);
		internal static global::net.sf.jni4net.jni.MethodId _publishResults10200;
		protected abstract void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1);
		internal static global::net.sf.jni4net.jni.MethodId _convertResultToString10201;
		public virtual global::java.lang.CharSequence convertResultToString(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Filter._convertResultToString10201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Filter.staticClass, global::android.widget.Filter._convertResultToString10201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Filter10202;
		public Filter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Filter.staticClass, global::android.widget.Filter._Filter10202, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.Filter.staticClass = @__class;
			global::android.widget.Filter._filter10197 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Filter._filter10198 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V");
			global::android.widget.Filter._performFiltering10199 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;");
			global::android.widget.Filter._publishResults10200 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V");
			global::android.widget.Filter._convertResultToString10201 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;");
			global::android.widget.Filter._Filter10202 = @__env.GetMethodID(global::android.widget.Filter.staticClass, "<init>", "()V");
		}
	}
	public static class FilterExtensionMethods
	{
		public static void filter(this global::android.widget.Filter __this, string arg0)
		{
			__this.filter((global::java.lang.String)arg0);
		}
		public static void filter(this global::android.widget.Filter __this, string arg0, android.widget.Filter.FilterListener arg1)
		{
			__this.filter((global::java.lang.String)arg0, arg1);
		}
	}
}
