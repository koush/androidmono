namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Contacts : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Contacts(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ContactMethods : java.lang.Object, BaseColumns, ContactMethodsColumns, PeopleColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ContactMethods(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, int arg2, java.lang.CharSequence arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.ContactMethods._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.ContactMethods._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.ContactMethods.staticClass, "getDisplayLabel", "(Landroid/content/Context;IILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.Contacts.ContactMethods.staticClass, global::android.provider.Contacts.ContactMethods._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
			}
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, int arg2, string arg3)
			{
				return getDisplayLabel(arg0, arg1, arg2, (global::java.lang.CharSequence)(global::java.lang.String)arg3);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.lang.String encodePredefinedImProtocol(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.ContactMethods._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.ContactMethods._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.ContactMethods.staticClass, "encodePredefinedImProtocol", "(I)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.Contacts.ContactMethods.staticClass, global::android.provider.Contacts.ContactMethods._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static global::java.lang.String encodeCustomImProtocol(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.ContactMethods._m2.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.ContactMethods._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.ContactMethods.staticClass, "encodeCustomImProtocol", "(Ljava/lang/String;)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.Contacts.ContactMethods.staticClass, global::android.provider.Contacts.ContactMethods._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static global::java.lang.Object decodeImProtocol(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.ContactMethods._m3.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.ContactMethods._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.ContactMethods.staticClass, "decodeImProtocol", "(Ljava/lang/String;)Ljava/lang/Object;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Contacts.ContactMethods.staticClass, global::android.provider.Contacts.ContactMethods._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public void addPostalLocation(android.content.Context arg0, long arg1, double arg2, double arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.provider.Contacts.ContactMethods.staticClass, "addPostalLocation", "(Landroid/content/Context;JDD)V", ref global::android.provider.Contacts.ContactMethods._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			public static global::java.lang.String POSTAL_LOCATION_LATITUDE
			{
				get
				{
					return "data";
				}
			}
			public static global::java.lang.String POSTAL_LOCATION_LONGITUDE
			{
				get
				{
					return "aux_data";
				}
			}
			public static int PROTOCOL_AIM
			{
				get
				{
					return 0;
				}
			}
			public static int PROTOCOL_MSN
			{
				get
				{
					return 1;
				}
			}
			public static int PROTOCOL_YAHOO
			{
				get
				{
					return 2;
				}
			}
			public static int PROTOCOL_SKYPE
			{
				get
				{
					return 3;
				}
			}
			public static int PROTOCOL_QQ
			{
				get
				{
					return 4;
				}
			}
			public static int PROTOCOL_GOOGLE_TALK
			{
				get
				{
					return 5;
				}
			}
			public static int PROTOCOL_ICQ
			{
				get
				{
					return 6;
				}
			}
			public static int PROTOCOL_JABBER
			{
				get
				{
					return 7;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4115;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.ContactMethods.staticClass, _CONTENT_URI4115)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_EMAIL_URI4116;
			public static global::android.net.Uri CONTENT_EMAIL_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.ContactMethods.staticClass, _CONTENT_EMAIL_URI4116)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/contact-methods";
				}
			}
			public static global::java.lang.String CONTENT_EMAIL_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/email";
				}
			}
			public static global::java.lang.String CONTENT_POSTAL_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/postal-address";
				}
			}
			public static global::java.lang.String CONTENT_EMAIL_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/email";
				}
			}
			public static global::java.lang.String CONTENT_POSTAL_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/postal-address";
				}
			}
			public static global::java.lang.String CONTENT_IM_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/jabber-im";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "name ASC";
				}
			}
			public static global::java.lang.String PERSON_ID
			{
				get
				{
					return "person";
				}
			}
			static ContactMethods()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.ContactMethods.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$ContactMethods"));
				global::android.provider.Contacts.ContactMethods._CONTENT_URI4115 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.ContactMethods.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.Contacts.ContactMethods._CONTENT_EMAIL_URI4116 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.ContactMethods.staticClass, "CONTENT_EMAIL_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.ContactMethodsColumns_))]
		public partial interface ContactMethodsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.ContactMethodsColumns))]
		internal sealed partial class ContactMethodsColumns_ : java.lang.Object, ContactMethodsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ContactMethodsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static ContactMethodsColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.ContactMethodsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$ContactMethodsColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class ContactMethodsColumnsConstants 
		{
			public static global::java.lang.String KIND
			{
				get
				{
					return "kind";
				}
			}
			public static global::java.lang.String TYPE
			{
				get
				{
					return "type";
				}
			}
			public static int TYPE_CUSTOM
			{
				get
				{
					return 0;
				}
			}
			public static int TYPE_HOME
			{
				get
				{
					return 1;
				}
			}
			public static int TYPE_WORK
			{
				get
				{
					return 2;
				}
			}
			public static int TYPE_OTHER
			{
				get
				{
					return 3;
				}
			}
			public static global::java.lang.String LABEL
			{
				get
				{
					return "label";
				}
			}
			public static global::java.lang.String DATA
			{
				get
				{
					return "data";
				}
			}
			public static global::java.lang.String AUX_DATA
			{
				get
				{
					return "aux_data";
				}
			}
			public static global::java.lang.String ISPRIMARY
			{
				get
				{
					return "isprimary";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Extensions : java.lang.Object, BaseColumns, ExtensionsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Extensions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4135;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Extensions.staticClass, _CONTENT_URI4135)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/contact_extensions";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/contact_extensions";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "person, name ASC";
				}
			}
			public static global::java.lang.String PERSON_ID
			{
				get
				{
					return "person";
				}
			}
			static Extensions()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Extensions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Extensions"));
				global::android.provider.Contacts.Extensions._CONTENT_URI4135 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Extensions.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.ExtensionsColumns_))]
		public partial interface ExtensionsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.ExtensionsColumns))]
		internal sealed partial class ExtensionsColumns_ : java.lang.Object, ExtensionsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ExtensionsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static ExtensionsColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.ExtensionsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$ExtensionsColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class ExtensionsColumnsConstants 
		{
			public static global::java.lang.String NAME
			{
				get
				{
					return "name";
				}
			}
			public static global::java.lang.String VALUE
			{
				get
				{
					return "value";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class GroupMembership : java.lang.Object, BaseColumns, GroupsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal GroupMembership(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4142;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.GroupMembership.staticClass, _CONTENT_URI4142)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RAW_CONTENT_URI4143;
			public static global::android.net.Uri RAW_CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.GroupMembership.staticClass, _RAW_CONTENT_URI4143)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "groupmembership";
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/contactsgroupmembership";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/contactsgroupmembership";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "group_id ASC";
				}
			}
			public static global::java.lang.String GROUP_ID
			{
				get
				{
					return "group_id";
				}
			}
			public static global::java.lang.String GROUP_SYNC_ID
			{
				get
				{
					return "group_sync_id";
				}
			}
			public static global::java.lang.String GROUP_SYNC_ACCOUNT
			{
				get
				{
					return "group_sync_account";
				}
			}
			public static global::java.lang.String GROUP_SYNC_ACCOUNT_TYPE
			{
				get
				{
					return "group_sync_account_type";
				}
			}
			public static global::java.lang.String PERSON_ID
			{
				get
				{
					return "person";
				}
			}
			static GroupMembership()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.GroupMembership.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$GroupMembership"));
				global::android.provider.Contacts.GroupMembership._CONTENT_URI4142 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.GroupMembership.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.Contacts.GroupMembership._RAW_CONTENT_URI4143 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.GroupMembership.staticClass, "RAW_CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Groups : java.lang.Object, BaseColumns, GroupsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Groups(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4153;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Groups.staticClass, _CONTENT_URI4153)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DELETED_CONTENT_URI4154;
			public static global::android.net.Uri DELETED_CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Groups.staticClass, _DELETED_CONTENT_URI4154)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/contactsgroup";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/contactsgroup";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "name ASC";
				}
			}
			public static global::java.lang.String GROUP_ANDROID_STARRED
			{
				get
				{
					return "Starred in Android";
				}
			}
			public static global::java.lang.String GROUP_MY_CONTACTS
			{
				get
				{
					return "Contacts";
				}
			}
			static Groups()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Groups.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Groups"));
				global::android.provider.Contacts.Groups._CONTENT_URI4153 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Groups.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.Contacts.Groups._DELETED_CONTENT_URI4154 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Groups.staticClass, "DELETED_CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.GroupsColumns_))]
		public partial interface GroupsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.GroupsColumns))]
		internal sealed partial class GroupsColumns_ : java.lang.Object, GroupsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal GroupsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static GroupsColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.GroupsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$GroupsColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class GroupsColumnsConstants 
		{
			public static global::java.lang.String NAME
			{
				get
				{
					return "name";
				}
			}
			public static global::java.lang.String NOTES
			{
				get
				{
					return "notes";
				}
			}
			public static global::java.lang.String SHOULD_SYNC
			{
				get
				{
					return "should_sync";
				}
			}
			public static global::java.lang.String SYSTEM_ID
			{
				get
				{
					return "system_id";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Intents : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Intents(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Insert : java.lang.Object
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Insert(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public Insert() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.Contacts.Intents.Insert._m0.native == global::System.IntPtr.Zero)
						global::android.provider.Contacts.Intents.Insert._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Contacts.Intents.Insert.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Contacts.Intents.Insert.staticClass, global::android.provider.Contacts.Intents.Insert._m0);
					Init(@__env, handle);
				}
				public static global::java.lang.String ACTION
				{
					get
					{
						return "android.intent.action.INSERT";
					}
				}
				public static global::java.lang.String FULL_MODE
				{
					get
					{
						return "full_mode";
					}
				}
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
				public static global::java.lang.String PHONETIC_NAME
				{
					get
					{
						return "phonetic_name";
					}
				}
				public static global::java.lang.String COMPANY
				{
					get
					{
						return "company";
					}
				}
				public static global::java.lang.String JOB_TITLE
				{
					get
					{
						return "job_title";
					}
				}
				public static global::java.lang.String NOTES
				{
					get
					{
						return "notes";
					}
				}
				public static global::java.lang.String PHONE
				{
					get
					{
						return "phone";
					}
				}
				public static global::java.lang.String PHONE_TYPE
				{
					get
					{
						return "phone_type";
					}
				}
				public static global::java.lang.String PHONE_ISPRIMARY
				{
					get
					{
						return "phone_isprimary";
					}
				}
				public static global::java.lang.String SECONDARY_PHONE
				{
					get
					{
						return "secondary_phone";
					}
				}
				public static global::java.lang.String SECONDARY_PHONE_TYPE
				{
					get
					{
						return "secondary_phone_type";
					}
				}
				public static global::java.lang.String TERTIARY_PHONE
				{
					get
					{
						return "tertiary_phone";
					}
				}
				public static global::java.lang.String TERTIARY_PHONE_TYPE
				{
					get
					{
						return "tertiary_phone_type";
					}
				}
				public static global::java.lang.String EMAIL
				{
					get
					{
						return "email";
					}
				}
				public static global::java.lang.String EMAIL_TYPE
				{
					get
					{
						return "email_type";
					}
				}
				public static global::java.lang.String EMAIL_ISPRIMARY
				{
					get
					{
						return "email_isprimary";
					}
				}
				public static global::java.lang.String SECONDARY_EMAIL
				{
					get
					{
						return "secondary_email";
					}
				}
				public static global::java.lang.String SECONDARY_EMAIL_TYPE
				{
					get
					{
						return "secondary_email_type";
					}
				}
				public static global::java.lang.String TERTIARY_EMAIL
				{
					get
					{
						return "tertiary_email";
					}
				}
				public static global::java.lang.String TERTIARY_EMAIL_TYPE
				{
					get
					{
						return "tertiary_email_type";
					}
				}
				public static global::java.lang.String POSTAL
				{
					get
					{
						return "postal";
					}
				}
				public static global::java.lang.String POSTAL_TYPE
				{
					get
					{
						return "postal_type";
					}
				}
				public static global::java.lang.String POSTAL_ISPRIMARY
				{
					get
					{
						return "postal_isprimary";
					}
				}
				public static global::java.lang.String IM_HANDLE
				{
					get
					{
						return "im_handle";
					}
				}
				public static global::java.lang.String IM_PROTOCOL
				{
					get
					{
						return "im_protocol";
					}
				}
				public static global::java.lang.String IM_ISPRIMARY
				{
					get
					{
						return "im_isprimary";
					}
				}
				static Insert()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.Contacts.Intents.Insert.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Intents$Insert"));
				}
				internal static void InitJNI()
				{
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class UI : java.lang.Object
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal UI(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public UI() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.Contacts.Intents.UI._m0.native == global::System.IntPtr.Zero)
						global::android.provider.Contacts.Intents.UI._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Contacts.Intents.UI.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Contacts.Intents.UI.staticClass, global::android.provider.Contacts.Intents.UI._m0);
					Init(@__env, handle);
				}
				public static global::java.lang.String LIST_DEFAULT
				{
					get
					{
						return "com.android.contacts.action.LIST_DEFAULT";
					}
				}
				public static global::java.lang.String LIST_GROUP_ACTION
				{
					get
					{
						return "com.android.contacts.action.LIST_GROUP";
					}
				}
				public static global::java.lang.String GROUP_NAME_EXTRA_KEY
				{
					get
					{
						return "com.android.contacts.extra.GROUP";
					}
				}
				public static global::java.lang.String LIST_ALL_CONTACTS_ACTION
				{
					get
					{
						return "com.android.contacts.action.LIST_ALL_CONTACTS";
					}
				}
				public static global::java.lang.String LIST_CONTACTS_WITH_PHONES_ACTION
				{
					get
					{
						return "com.android.contacts.action.LIST_CONTACTS_WITH_PHONES";
					}
				}
				public static global::java.lang.String LIST_STARRED_ACTION
				{
					get
					{
						return "com.android.contacts.action.LIST_STARRED";
					}
				}
				public static global::java.lang.String LIST_FREQUENT_ACTION
				{
					get
					{
						return "com.android.contacts.action.LIST_FREQUENT";
					}
				}
				public static global::java.lang.String LIST_STREQUENT_ACTION
				{
					get
					{
						return "com.android.contacts.action.LIST_STREQUENT";
					}
				}
				public static global::java.lang.String TITLE_EXTRA_KEY
				{
					get
					{
						return "com.android.contacts.extra.TITLE_EXTRA";
					}
				}
				public static global::java.lang.String FILTER_CONTACTS_ACTION
				{
					get
					{
						return "com.android.contacts.action.FILTER_CONTACTS";
					}
				}
				public static global::java.lang.String FILTER_TEXT_EXTRA_KEY
				{
					get
					{
						return "com.android.contacts.extra.FILTER_TEXT";
					}
				}
				static UI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.Contacts.Intents.UI.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Intents$UI"));
				}
				internal static void InitJNI()
				{
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public Intents() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.Intents._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.Intents._m0 = @__env.GetMethodIDNoThrow(global::android.provider.Contacts.Intents.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.Contacts.Intents.staticClass, global::android.provider.Contacts.Intents._m0);
				Init(@__env, handle);
			}
			public static global::java.lang.String SEARCH_SUGGESTION_CLICKED
			{
				get
				{
					return "android.provider.Contacts.SEARCH_SUGGESTION_CLICKED";
				}
			}
			public static global::java.lang.String SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED
			{
				get
				{
					return "android.provider.Contacts.SEARCH_SUGGESTION_DIAL_NUMBER_CLICKED";
				}
			}
			public static global::java.lang.String SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED
			{
				get
				{
					return "android.provider.Contacts.SEARCH_SUGGESTION_CREATE_CONTACT_CLICKED";
				}
			}
			public static global::java.lang.String ATTACH_IMAGE
			{
				get
				{
					return "com.android.contacts.action.ATTACH_IMAGE";
				}
			}
			public static global::java.lang.String SHOW_OR_CREATE_CONTACT
			{
				get
				{
					return "com.android.contacts.action.SHOW_OR_CREATE_CONTACT";
				}
			}
			public static global::java.lang.String EXTRA_FORCE_CREATE
			{
				get
				{
					return "com.android.contacts.action.FORCE_CREATE";
				}
			}
			public static global::java.lang.String EXTRA_CREATE_DESCRIPTION
			{
				get
				{
					return "com.android.contacts.action.CREATE_DESCRIPTION";
				}
			}
			static Intents()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Intents.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Intents"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.OrganizationColumns_))]
		public partial interface OrganizationColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.OrganizationColumns))]
		internal sealed partial class OrganizationColumns_ : java.lang.Object, OrganizationColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OrganizationColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static OrganizationColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.OrganizationColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$OrganizationColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class OrganizationColumnsConstants 
		{
			public static global::java.lang.String TYPE
			{
				get
				{
					return "type";
				}
			}
			public static int TYPE_CUSTOM
			{
				get
				{
					return 0;
				}
			}
			public static int TYPE_WORK
			{
				get
				{
					return 1;
				}
			}
			public static int TYPE_OTHER
			{
				get
				{
					return 2;
				}
			}
			public static global::java.lang.String LABEL
			{
				get
				{
					return "label";
				}
			}
			public static global::java.lang.String COMPANY
			{
				get
				{
					return "company";
				}
			}
			public static global::java.lang.String TITLE
			{
				get
				{
					return "title";
				}
			}
			public static global::java.lang.String PERSON_ID
			{
				get
				{
					return "person";
				}
			}
			public static global::java.lang.String ISPRIMARY
			{
				get
				{
					return "isprimary";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Organizations : java.lang.Object, BaseColumns, OrganizationColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Organizations(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, java.lang.CharSequence arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.Organizations._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.Organizations._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.Organizations.staticClass, "getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.Contacts.Organizations.staticClass, global::android.provider.Contacts.Organizations._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
			}
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, string arg2)
			{
				return getDisplayLabel(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4218;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Organizations.staticClass, _CONTENT_URI4218)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "organizations";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "company, title, isprimary ASC";
				}
			}
			static Organizations()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Organizations.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Organizations"));
				global::android.provider.Contacts.Organizations._CONTENT_URI4218 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Organizations.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class People : java.lang.Object, BaseColumns, PeopleColumns, PhonesColumns, PresenceColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal People(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class ContactMethods : java.lang.Object, BaseColumns, ContactMethodsColumns, PeopleColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal ContactMethods(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "contact_methods";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "data ASC";
					}
				}
				static ContactMethods()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.Contacts.People.ContactMethods.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$People$ContactMethods"));
				}
				internal static void InitJNI()
				{
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public partial class Extensions : java.lang.Object, BaseColumns, ExtensionsColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				protected Extensions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "extensions";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name ASC";
					}
				}
				public static global::java.lang.String PERSON_ID
				{
					get
					{
						return "person";
					}
				}
				static Extensions()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.Contacts.People.Extensions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$People$Extensions"));
				}
				internal static void InitJNI()
				{
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Phones : java.lang.Object, BaseColumns, PhonesColumns, PeopleColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Phones(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				public static global::java.lang.String CONTENT_DIRECTORY
				{
					get
					{
						return "phones";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "number ASC";
					}
				}
				static Phones()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.Contacts.People.Phones.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$People$Phones"));
				}
				internal static void InitJNI()
				{
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static void markAsContacted(android.content.ContentResolver arg0, long arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "markAsContacted", "(Landroid/content/ContentResolver;J)V");
				@__env.CallStaticVoidMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.net.Uri addToMyContactsGroup(android.content.ContentResolver arg0, long arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "addToMyContactsGroup", "(Landroid/content/ContentResolver;J)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static global::android.net.Uri addToGroup(android.content.ContentResolver arg0, long arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m2.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "addToGroup", "(Landroid/content/ContentResolver;JLjava/lang/String;)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static global::android.net.Uri addToGroup(android.content.ContentResolver arg0, long arg1, long arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m3.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "addToGroup", "(Landroid/content/ContentResolver;JJ)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public static global::android.net.Uri createPersonInMyContactsGroup(android.content.ContentResolver arg0, android.content.ContentValues arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m4.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "createPersonInMyContactsGroup", "(Landroid/content/ContentResolver;Landroid/content/ContentValues;)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public static global::android.database.Cursor queryGroups(android.content.ContentResolver arg0, long arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m5.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "queryGroups", "(Landroid/content/ContentResolver;J)Landroid/database/Cursor;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public static void setPhotoData(android.content.ContentResolver arg0, android.net.Uri arg1, byte[] arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m6.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "setPhotoData", "(Landroid/content/ContentResolver;Landroid/net/Uri;[B)V");
				@__env.CallStaticVoidMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public static global::java.io.InputStream openContactPhotoInputStream(android.content.ContentResolver arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m7.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m7 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "openContactPhotoInputStream", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/io/InputStream;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public static global::android.graphics.Bitmap loadContactPhoto(android.content.Context arg0, android.net.Uri arg1, int arg2, android.graphics.BitmapFactory.Options arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.People._m8.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.People._m8 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.People.staticClass, "loadContactPhoto", "(Landroid/content/Context;Landroid/net/Uri;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.provider.Contacts.People.staticClass, global::android.provider.Contacts.People._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4228;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.People.staticClass, _CONTENT_URI4228)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URI4229;
			public static global::android.net.Uri CONTENT_FILTER_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.People.staticClass, _CONTENT_FILTER_URI4229)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DELETED_CONTENT_URI4230;
			public static global::android.net.Uri DELETED_CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.People.staticClass, _DELETED_CONTENT_URI4230)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/person";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/person";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "name ASC";
				}
			}
			public static global::java.lang.String PRIMARY_PHONE_ID
			{
				get
				{
					return "primary_phone";
				}
			}
			public static global::java.lang.String PRIMARY_EMAIL_ID
			{
				get
				{
					return "primary_email";
				}
			}
			public static global::java.lang.String PRIMARY_ORGANIZATION_ID
			{
				get
				{
					return "primary_organization";
				}
			}
			static People()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.People.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$People"));
				global::android.provider.Contacts.People._CONTENT_URI4228 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.People.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.Contacts.People._CONTENT_FILTER_URI4229 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.People.staticClass, "CONTENT_FILTER_URI", "Landroid/net/Uri;");
				global::android.provider.Contacts.People._DELETED_CONTENT_URI4230 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.People.staticClass, "DELETED_CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.PeopleColumns_))]
		public partial interface PeopleColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.PeopleColumns))]
		internal sealed partial class PeopleColumns_ : java.lang.Object, PeopleColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PeopleColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static PeopleColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.PeopleColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$PeopleColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PeopleColumnsConstants 
		{
			public static global::java.lang.String NAME
			{
				get
				{
					return "name";
				}
			}
			public static global::java.lang.String PHONETIC_NAME
			{
				get
				{
					return "phonetic_name";
				}
			}
			public static global::java.lang.String DISPLAY_NAME
			{
				get
				{
					return "display_name";
				}
			}
			public static global::java.lang.String NOTES
			{
				get
				{
					return "notes";
				}
			}
			public static global::java.lang.String TIMES_CONTACTED
			{
				get
				{
					return "times_contacted";
				}
			}
			public static global::java.lang.String LAST_TIME_CONTACTED
			{
				get
				{
					return "last_time_contacted";
				}
			}
			public static global::java.lang.String CUSTOM_RINGTONE
			{
				get
				{
					return "custom_ringtone";
				}
			}
			public static global::java.lang.String SEND_TO_VOICEMAIL
			{
				get
				{
					return "send_to_voicemail";
				}
			}
			public static global::java.lang.String STARRED
			{
				get
				{
					return "starred";
				}
			}
			public static global::java.lang.String PHOTO_VERSION
			{
				get
				{
					return "photo_version";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Phones : java.lang.Object, BaseColumns, PhonesColumns, PeopleColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Phones(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence[] arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.Phones._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.Phones._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.Phones.staticClass, "getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.Contacts.Phones.staticClass, global::android.provider.Contacts.Phones._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
			}
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, string arg2, java.lang.CharSequence[] arg3)
			{
				return getDisplayLabel(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, java.lang.CharSequence arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.Phones._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.Phones._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.Phones.staticClass, "getDisplayLabel", "(Landroid/content/Context;ILjava/lang/CharSequence;)Ljava/lang/CharSequence;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.provider.Contacts.Phones.staticClass, global::android.provider.Contacts.Phones._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
			}
			public static java.lang.CharSequence getDisplayLabel(android.content.Context arg0, int arg1, string arg2)
			{
				return getDisplayLabel(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4247;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Phones.staticClass, _CONTENT_URI4247)) as android.net.Uri;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_FILTER_URL4248;
			public static global::android.net.Uri CONTENT_FILTER_URL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Phones.staticClass, _CONTENT_FILTER_URL4248)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_TYPE
			{
				get
				{
					return "vnd.android.cursor.dir/phone";
				}
			}
			public static global::java.lang.String CONTENT_ITEM_TYPE
			{
				get
				{
					return "vnd.android.cursor.item/phone";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "name ASC";
				}
			}
			public static global::java.lang.String PERSON_ID
			{
				get
				{
					return "person";
				}
			}
			static Phones()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Phones.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Phones"));
				global::android.provider.Contacts.Phones._CONTENT_URI4247 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Phones.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
				global::android.provider.Contacts.Phones._CONTENT_FILTER_URL4248 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Phones.staticClass, "CONTENT_FILTER_URL", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.PhonesColumns_))]
		public partial interface PhonesColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.PhonesColumns))]
		internal sealed partial class PhonesColumns_ : java.lang.Object, PhonesColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PhonesColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static PhonesColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.PhonesColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$PhonesColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PhonesColumnsConstants 
		{
			public static global::java.lang.String TYPE
			{
				get
				{
					return "type";
				}
			}
			public static int TYPE_CUSTOM
			{
				get
				{
					return 0;
				}
			}
			public static int TYPE_HOME
			{
				get
				{
					return 1;
				}
			}
			public static int TYPE_MOBILE
			{
				get
				{
					return 2;
				}
			}
			public static int TYPE_WORK
			{
				get
				{
					return 3;
				}
			}
			public static int TYPE_FAX_WORK
			{
				get
				{
					return 4;
				}
			}
			public static int TYPE_FAX_HOME
			{
				get
				{
					return 5;
				}
			}
			public static int TYPE_PAGER
			{
				get
				{
					return 6;
				}
			}
			public static int TYPE_OTHER
			{
				get
				{
					return 7;
				}
			}
			public static global::java.lang.String LABEL
			{
				get
				{
					return "label";
				}
			}
			public static global::java.lang.String NUMBER
			{
				get
				{
					return "number";
				}
			}
			public static global::java.lang.String NUMBER_KEY
			{
				get
				{
					return "number_key";
				}
			}
			public static global::java.lang.String ISPRIMARY
			{
				get
				{
					return "isprimary";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Photos : java.lang.Object, BaseColumns, PhotosColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Photos(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4266;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Photos.staticClass, _CONTENT_URI4266)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "photo";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "person ASC";
				}
			}
			static Photos()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Photos.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Photos"));
				global::android.provider.Contacts.Photos._CONTENT_URI4266 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Photos.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.PhotosColumns_))]
		public partial interface PhotosColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.PhotosColumns))]
		internal sealed partial class PhotosColumns_ : java.lang.Object, PhotosColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PhotosColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static PhotosColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.PhotosColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$PhotosColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PhotosColumnsConstants 
		{
			public static global::java.lang.String LOCAL_VERSION
			{
				get
				{
					return "local_version";
				}
			}
			public static global::java.lang.String PERSON_ID
			{
				get
				{
					return "person";
				}
			}
			public static global::java.lang.String DOWNLOAD_REQUIRED
			{
				get
				{
					return "download_required";
				}
			}
			public static global::java.lang.String EXISTS_ON_SERVER
			{
				get
				{
					return "exists_on_server";
				}
			}
			public static global::java.lang.String SYNC_ERROR
			{
				get
				{
					return "sync_error";
				}
			}
			public static global::java.lang.String DATA
			{
				get
				{
					return "data";
				}
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.PresenceColumns_))]
		public partial interface PresenceColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.PresenceColumns))]
		internal sealed partial class PresenceColumns_ : java.lang.Object, PresenceColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PresenceColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static PresenceColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.PresenceColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$PresenceColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class PresenceColumnsConstants 
		{
			public static global::java.lang.String PRIORITY
			{
				get
				{
					return "priority";
				}
			}
			public static global::java.lang.String PRESENCE_STATUS
			{
				get
				{
					return "mode";
				}
			}
			public static int OFFLINE
			{
				get
				{
					return 0;
				}
			}
			public static int INVISIBLE
			{
				get
				{
					return 1;
				}
			}
			public static int AWAY
			{
				get
				{
					return 2;
				}
			}
			public static int IDLE
			{
				get
				{
					return 3;
				}
			}
			public static int DO_NOT_DISTURB
			{
				get
				{
					return 4;
				}
			}
			public static int AVAILABLE
			{
				get
				{
					return 5;
				}
			}
			public static global::java.lang.String PRESENCE_CUSTOM_STATUS
			{
				get
				{
					return "status";
				}
			}
			public static global::java.lang.String IM_PROTOCOL
			{
				get
				{
					return "im_protocol";
				}
			}
			public static global::java.lang.String IM_HANDLE
			{
				get
				{
					return "im_handle";
				}
			}
			public static global::java.lang.String IM_ACCOUNT
			{
				get
				{
					return "im_account";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Settings : java.lang.Object, BaseColumns, SettingsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Settings(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.String getSetting(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.Settings._m0.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.Settings._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.Settings.staticClass, "getSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.Contacts.Settings.staticClass, global::android.provider.Contacts.Settings._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static void setSetting(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.Contacts.Settings._m1.native == global::System.IntPtr.Zero)
					global::android.provider.Contacts.Settings._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.Contacts.Settings.staticClass, "setSetting", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				@__env.CallStaticVoidMethod(android.provider.Contacts.Settings.staticClass, global::android.provider.Contacts.Settings._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.FieldId _CONTENT_URI4287;
			public static global::android.net.Uri CONTENT_URI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.Settings.staticClass, _CONTENT_URI4287)) as android.net.Uri;
				}
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "settings";
				}
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "key ASC";
				}
			}
			public static global::java.lang.String SYNC_EVERYTHING
			{
				get
				{
					return "syncEverything";
				}
			}
			static Settings()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.Settings.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$Settings"));
				global::android.provider.Contacts.Settings._CONTENT_URI4287 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.Settings.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.Contacts.SettingsColumns_))]
		public partial interface SettingsColumns  : global::MonoJavaBridge.IJavaObject 
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.Contacts.SettingsColumns))]
		internal sealed partial class SettingsColumns_ : java.lang.Object, SettingsColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal SettingsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static SettingsColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.Contacts.SettingsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts$SettingsColumns"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class SettingsColumnsConstants 
		{
			public static global::java.lang.String _SYNC_ACCOUNT
			{
				get
				{
					return "_sync_account";
				}
			}
			public static global::java.lang.String _SYNC_ACCOUNT_TYPE
			{
				get
				{
					return "_sync_account_type";
				}
			}
			public static global::java.lang.String KEY
			{
				get
				{
					return "key";
				}
			}
			public static global::java.lang.String VALUE
			{
				get
				{
					return "value";
				}
			}
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "contacts";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONTENT_URI4296;
		public static global::android.net.Uri CONTENT_URI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.Contacts.staticClass, _CONTENT_URI4296)) as android.net.Uri;
			}
		}
		public static int KIND_EMAIL
		{
			get
			{
				return 1;
			}
		}
		public static int KIND_POSTAL
		{
			get
			{
				return 2;
			}
		}
		public static int KIND_IM
		{
			get
			{
				return 3;
			}
		}
		public static int KIND_ORGANIZATION
		{
			get
			{
				return 4;
			}
		}
		public static int KIND_PHONE
		{
			get
			{
				return 5;
			}
		}
		static Contacts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.Contacts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/Contacts"));
			global::android.provider.Contacts._CONTENT_URI4296 = @__env.GetStaticFieldIDNoThrow(global::android.provider.Contacts.staticClass, "CONTENT_URI", "Landroid/net/Uri;");
		}
		internal static void InitJNI()
		{
		}
	}
}
