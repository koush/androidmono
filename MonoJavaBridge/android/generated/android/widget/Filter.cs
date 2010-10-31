namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.Filter_))]
	public abstract partial class Filter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Filter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Filter.FilterListener_))]
		public partial interface FilterListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFilterComplete(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filter.FilterListener))]
		internal sealed partial class FilterListener_ : java.lang.Object, FilterListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal FilterListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.Filter.FilterListener.onFilterComplete(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Filter.FilterListener_.staticClass, "onFilterComplete", "(I)V", ref global::android.widget.Filter.FilterListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static FilterListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter$FilterListener"));
			}
		}

		public delegate void FilterListenerDelegate(int arg0);

		internal partial class FilterListenerDelegateWrapper : java.lang.Object, FilterListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FilterListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public FilterListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Filter.FilterListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.Filter.FilterListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.FilterListenerDelegateWrapper.staticClass, global::android.widget.Filter.FilterListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static FilterListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter_FilterListenerDelegateWrapper"));
			}
		}
		internal partial class FilterListenerDelegateWrapper
		{
			private FilterListenerDelegate myDelegate;
			public void onFilterComplete(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator FilterListenerDelegateWrapper(FilterListenerDelegate d)
			{
				global::android.widget.Filter.FilterListenerDelegateWrapper ret = new global::android.widget.Filter.FilterListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class FilterResults : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FilterResults(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public FilterResults() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Filter.FilterResults._m0.native == global::System.IntPtr.Zero)
					global::android.widget.Filter.FilterResults._m0 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.FilterResults.staticClass, global::android.widget.Filter.FilterResults._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _values6055;
			public global::java.lang.Object values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _values6055)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _count6056;
			public int count
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _count6056);
				}
				set
				{
				}
			}
			static FilterResults()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Filter.FilterResults.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter$FilterResults"));
				global::android.widget.Filter.FilterResults._values6055 = @__env.GetFieldIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "values", "Ljava/lang/Object;");
				global::android.widget.Filter.FilterResults._count6056 = @__env.GetFieldIDNoThrow(global::android.widget.Filter.FilterResults.staticClass, "count", "I");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void filter(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;)V", ref global::android.widget.Filter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void filter(string arg0)
		{
			filter((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void filter(java.lang.CharSequence arg0, android.widget.Filter.FilterListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Filter.staticClass, "filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V", ref global::android.widget.Filter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void filter(string arg0, global::android.widget.Filter.FilterListenerDelegate arg1)
		{
			filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.widget.Filter.FilterListenerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence convertResultToString(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.Filter.staticClass, "convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", ref global::android.widget.Filter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Filter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Filter._m5.native == global::System.IntPtr.Zero)
				global::android.widget.Filter._m5 = @__env.GetMethodIDNoThrow(global::android.widget.Filter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Filter.staticClass, global::android.widget.Filter._m5);
			Init(@__env, handle);
		}
		static Filter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filter))]
	internal sealed partial class Filter_ : android.widget.Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::android.widget.Filter.FilterResults performFiltering(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Filter_.staticClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;", ref global::android.widget.Filter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.Filter.FilterResults;
		}
		protected android.widget.Filter.FilterResults performFiltering(string arg0)
		{
			return performFiltering((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void publishResults(java.lang.CharSequence arg0, android.widget.Filter.FilterResults arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Filter_.staticClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V", ref global::android.widget.Filter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void publishResults(string arg0, android.widget.Filter.FilterResults arg1)
		{
			publishResults((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		static Filter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filter"));
		}
	}
}
