namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IntentFilter : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntentFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AuthorityEntry : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AuthorityEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new int Port
			{
				get
				{
					return getPort();
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public int getPort()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, "getPort", "()I", ref global::android.content.IntentFilter.AuthorityEntry._m0);
			}
			public new global::java.lang.String Host
			{
				get
				{
					return getHost();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public global::java.lang.String getHost()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, "getHost", "()Ljava/lang/String;", ref global::android.content.IntentFilter.AuthorityEntry._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public int match(android.net.Uri arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.AuthorityEntry.staticClass, "match", "(Landroid/net/Uri;)I", ref global::android.content.IntentFilter.AuthorityEntry._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public AuthorityEntry(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.AuthorityEntry._m3.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.AuthorityEntry._m3 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.AuthorityEntry.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.AuthorityEntry.staticClass, global::android.content.IntentFilter.AuthorityEntry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static AuthorityEntry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.AuthorityEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$AuthorityEntry"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MalformedMimeTypeException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MalformedMimeTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public MalformedMimeTypeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.MalformedMimeTypeException._m0.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.MalformedMimeTypeException._m0 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._m0);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public MalformedMimeTypeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentFilter.MalformedMimeTypeException._m1.native == global::System.IntPtr.Zero)
					global::android.content.IntentFilter.MalformedMimeTypeException._m1 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.MalformedMimeTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.MalformedMimeTypeException.staticClass, global::android.content.IntentFilter.MalformedMimeTypeException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static MalformedMimeTypeException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentFilter.MalformedMimeTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter$MalformedMimeTypeException"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "setPriority", "(I)V", ref global::android.content.IntentFilter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Priority
		{
			get
			{
				return getPriority();
			}
			set
			{
				setPriority(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getPriority()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "getPriority", "()I", ref global::android.content.IntentFilter._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.content.IntentFilter create(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._m2.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._m2 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.IntentFilter;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int match(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.net.Uri arg3, java.util.Set arg4, java.lang.String arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/util/Set;Ljava/lang/String;)I", ref global::android.content.IntentFilter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int match(android.content.ContentResolver arg0, android.content.Intent arg1, bool arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I", ref global::android.content.IntentFilter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.IntentFilter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.IntentFilter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "describeContents", "()I", ref global::android.content.IntentFilter._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, "getAction", "(I)Ljava/lang/String;", ref global::android.content.IntentFilter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool hasCategory(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "hasCategory", "(Ljava/lang/String;)Z", ref global::android.content.IntentFilter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addCategory(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "addCategory", "(Ljava/lang/String;)V", ref global::android.content.IntentFilter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addAction(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "addAction", "(Ljava/lang/String;)V", ref global::android.content.IntentFilter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int countActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "countActions", "()I", ref global::android.content.IntentFilter._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool hasAction(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "hasAction", "(Ljava/lang/String;)Z", ref global::android.content.IntentFilter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool matchAction(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "matchAction", "(Ljava/lang/String;)Z", ref global::android.content.IntentFilter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.util.Iterator actionsIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, "actionsIterator", "()Ljava/util/Iterator;", ref global::android.content.IntentFilter._m15) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void addDataType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "addDataType", "(Ljava/lang/String;)V", ref global::android.content.IntentFilter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool hasDataType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "hasDataType", "(Ljava/lang/String;)Z", ref global::android.content.IntentFilter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int countDataTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "countDataTypes", "()I", ref global::android.content.IntentFilter._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.lang.String getDataType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, "getDataType", "(I)Ljava/lang/String;", ref global::android.content.IntentFilter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.util.Iterator typesIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, "typesIterator", "()Ljava/util/Iterator;", ref global::android.content.IntentFilter._m20) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void addDataScheme(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "addDataScheme", "(Ljava/lang/String;)V", ref global::android.content.IntentFilter._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int countDataSchemes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "countDataSchemes", "()I", ref global::android.content.IntentFilter._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.String getDataScheme(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, "getDataScheme", "(I)Ljava/lang/String;", ref global::android.content.IntentFilter._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool hasDataScheme(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "hasDataScheme", "(Ljava/lang/String;)Z", ref global::android.content.IntentFilter._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.util.Iterator schemesIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, "schemesIterator", "()Ljava/util/Iterator;", ref global::android.content.IntentFilter._m25) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void addDataAuthority(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.IntentFilter._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int countDataAuthorities()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "countDataAuthorities", "()I", ref global::android.content.IntentFilter._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.content.IntentFilter.AuthorityEntry getDataAuthority(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.IntentFilter.AuthorityEntry>(this, global::android.content.IntentFilter.staticClass, "getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;", ref global::android.content.IntentFilter._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.IntentFilter.AuthorityEntry;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool hasDataAuthority(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "hasDataAuthority", "(Landroid/net/Uri;)Z", ref global::android.content.IntentFilter._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.util.Iterator authoritiesIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, "authoritiesIterator", "()Ljava/util/Iterator;", ref global::android.content.IntentFilter._m30) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void addDataPath(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "addDataPath", "(Ljava/lang/String;I)V", ref global::android.content.IntentFilter._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual int countDataPaths()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "countDataPaths", "()I", ref global::android.content.IntentFilter._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::android.os.PatternMatcher getDataPath(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.IntentFilter.staticClass, "getDataPath", "(I)Landroid/os/PatternMatcher;", ref global::android.content.IntentFilter._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.PatternMatcher;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool hasDataPath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentFilter.staticClass, "hasDataPath", "(Ljava/lang/String;)Z", ref global::android.content.IntentFilter._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.util.Iterator pathsIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, "pathsIterator", "()Ljava/util/Iterator;", ref global::android.content.IntentFilter._m35) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual int matchDataAuthority(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "matchDataAuthority", "(Landroid/net/Uri;)I", ref global::android.content.IntentFilter._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual int matchData(java.lang.String arg0, java.lang.String arg1, android.net.Uri arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I", ref global::android.content.IntentFilter._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual int countCategories()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentFilter.staticClass, "countCategories", "()I", ref global::android.content.IntentFilter._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::java.lang.String getCategory(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, "getCategory", "(I)Ljava/lang/String;", ref global::android.content.IntentFilter._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.util.Iterator categoriesIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::android.content.IntentFilter.staticClass, "categoriesIterator", "()Ljava/util/Iterator;", ref global::android.content.IntentFilter._m40) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::java.lang.String matchCategories(java.util.Set arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentFilter.staticClass, "matchCategories", "(Ljava/util/Set;)Ljava/lang/String;", ref global::android.content.IntentFilter._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void writeToXml(org.xmlpull.v1.XmlSerializer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V", ref global::android.content.IntentFilter._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void readFromXml(org.xmlpull.v1.XmlPullParser arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentFilter.staticClass, "readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V", ref global::android.content.IntentFilter._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public IntentFilter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._m44.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._m44 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._m44);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public IntentFilter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._m45.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._m45 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public IntentFilter(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._m46.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._m46 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public IntentFilter(android.content.IntentFilter arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentFilter._m47.native == global::System.IntPtr.Zero)
				global::android.content.IntentFilter._m47 = @__env.GetMethodIDNoThrow(global::android.content.IntentFilter.staticClass, "<init>", "(Landroid/content/IntentFilter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentFilter.staticClass, global::android.content.IntentFilter._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int SYSTEM_HIGH_PRIORITY
		{
			get
			{
				return 1000;
			}
		}
		public static int SYSTEM_LOW_PRIORITY
		{
			get
			{
				return -1000;
			}
		}
		public static int MATCH_CATEGORY_MASK
		{
			get
			{
				return 268369920;
			}
		}
		public static int MATCH_ADJUSTMENT_MASK
		{
			get
			{
				return 65535;
			}
		}
		public static int MATCH_ADJUSTMENT_NORMAL
		{
			get
			{
				return 32768;
			}
		}
		public static int MATCH_CATEGORY_EMPTY
		{
			get
			{
				return 1048576;
			}
		}
		public static int MATCH_CATEGORY_SCHEME
		{
			get
			{
				return 2097152;
			}
		}
		public static int MATCH_CATEGORY_HOST
		{
			get
			{
				return 3145728;
			}
		}
		public static int MATCH_CATEGORY_PORT
		{
			get
			{
				return 4194304;
			}
		}
		public static int MATCH_CATEGORY_PATH
		{
			get
			{
				return 5242880;
			}
		}
		public static int MATCH_CATEGORY_TYPE
		{
			get
			{
				return 6291456;
			}
		}
		public static int NO_MATCH_TYPE
		{
			get
			{
				return -1;
			}
		}
		public static int NO_MATCH_DATA
		{
			get
			{
				return -2;
			}
		}
		public static int NO_MATCH_ACTION
		{
			get
			{
				return -3;
			}
		}
		public static int NO_MATCH_CATEGORY
		{
			get
			{
				return -4;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1869;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.IntentFilter.staticClass, _CREATOR1869)) as android.os.Parcelable_Creator;
			}
		}
		static IntentFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.IntentFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentFilter"));
			global::android.content.IntentFilter._CREATOR1869 = @__env.GetStaticFieldIDNoThrow(global::android.content.IntentFilter.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
